namespace Belly.Net;

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class SocketConnection(SocketServerConfig config, ILogger logger) : IConnection, IRecevicable
{
    private readonly ILogger logger = logger;
    private readonly SocketServerConfig config = config;
    private Socket socket;
    private readonly Pipe input = new();
    private readonly Pipe output = new();
    private readonly List<ArraySegment<byte>> forSend = [];
    private readonly SemaphoreSlim semaphore = new(1, 1);

    public string ID { get; private set; } = $"{DateTimeOffset.UtcNow.ToString("yyyyMMddHHmmssfff")}{Guid.NewGuid():N}";
    public bool IsConnected => this.socket?.Connected ?? false;
    public IPEndPoint RemoteEndPoint => this.socket?.RemoteEndPoint as IPEndPoint;
    public IPEndPoint LocalEndPoint => this.socket?.LocalEndPoint as IPEndPoint;
    public DateTimeOffset LastActiveTime { get; private set; }
    public event Func<IConnection, ReadOnlySequence<byte>, SequencePosition> OnMessageReceived;
    public event Action<IConnection> OnDisconnected;

    public async ValueTask AcceptAsync(Socket socket)
    {
        this.logger.LogInformation($"the socket connection[{this.ID}] accepted a socket client from {socket.RemoteEndPoint}");
        this.socket = socket;
        this.socket.NoDelay = true;
        this.socket.LingerState = new LingerOption(false, 0);
        this.socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
        this.socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, false);
        this.socket.ReceiveBufferSize = this.config.ReceiveBufferSize;
        this.socket.SendBufferSize = this.config.SendBufferSize;
        this.socket.ReceiveTimeout = this.config.ReceiveTimeout;
        this.socket.SendTimeout = this.config.SendTimeout;
        this.LastActiveTime = DateTimeOffset.UtcNow;
        Task receivingTask = this.DoReceiving();
        Task sendingTask = this.DoSending();
        await Task.WhenAll(receivingTask, sendingTask);
        this.Dispose();
        this.OnDisconnected?.Invoke(this);
    }

    public async ValueTask SendAsync(ReadOnlyMemory<byte> memory)
    {
        try
        {
            await this.semaphore.WaitAsync();
            await this.output.Writer.WriteAsync(memory);
            await this.output.Writer.FlushAsync();
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, $"the socket connection[{this}] failed to write to pipe");
        }
        finally
        {
            this.semaphore.Release();
        }
    }

    public void Dispose()
    {
        try
        {
            this.input.Reset();
            this.output.Reset();
            this.socket?.Shutdown(SocketShutdown.Both);
            this.socket?.Dispose();
        }
        catch
        {

        }
        finally
        {
            this.socket = null;
        }
    }

    public override string ToString()
    {
        return $"ID: {this.ID}, RemoteEndPoint: {this.RemoteEndPoint}, LocalEndPoint: {this.LocalEndPoint}, IsConnected: {this.IsConnected}";
    }

    private async Task DoReceiving()
    {
        Task fillPipeTask = this.FillPipeAsync();
        Task readPipeTask = this.ReadPipeAsync();
        await Task.WhenAll(fillPipeTask, readPipeTask);
    }

    private async Task FillPipeAsync()
    {
        while (true)
        {
            try
            {
                Memory<byte> memory = this.input.Writer.GetMemory(this.config.BlockSize / 2);
                int bytesReceived = await this.socket.ReceiveAsync(memory, SocketFlags.None);
                if (bytesReceived <= 0)
                {
                    this.input.Reader.CancelPendingRead();
                    this.output.Reader.CancelPendingRead();
                    break;
                }
                this.input.Writer.Advance(bytesReceived);
                FlushResult flushResult = await this.input.Writer.FlushAsync();
                if (flushResult.IsCompleted || flushResult.IsCanceled)
                {
                    break;
                }
                this.LastActiveTime = DateTimeOffset.UtcNow;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, $"the socket connection[{this}] failed to receive");
                break;
            }
        }
        this.input.Writer.Complete();
    }

    private async Task ReadPipeAsync()
    {
        while (true)
        {
            try
            {
                ReadResult readResult = await this.input.Reader.ReadAsync();
                if (readResult.IsCanceled)
                {
                    break;
                }
                if (!readResult.Buffer.IsEmpty)
                {
                    SequencePosition consumed = this.OnMessageReceived?.Invoke(this, readResult.Buffer) ?? readResult.Buffer.End;
                    this.input.Reader.AdvanceTo(consumed);
                }
                if (readResult.IsCompleted)
                {
                    if (readResult.Buffer.Length > 0)
                    {
                        this.logger.LogWarning($"the socket connection[{this}] has some data left");
                    }
                    break;
                }
            }
            catch (Exception exception)
            {
                this.logger.LogError(exception, $"the socket connection[{this}] failed to read from pipe");
                break;
            }
        }
        this.input.Reader.Complete();
    }

    private async Task DoSending()
    {
        while (true)
        {
            try
            {
                ReadResult readResult = await this.output.Reader.ReadAsync();
                if (readResult.IsCanceled)
                {
                    break;
                }
                if (!readResult.Buffer.IsEmpty)
                {
                    if (readResult.Buffer.IsSingleSegment)
                    {
                        await this.socket.SendAsync(readResult.Buffer.First, SocketFlags.None);
                    }
                    else
                    {
                        this.forSend.Clear();
                        foreach (ReadOnlyMemory<byte> segment in readResult.Buffer)
                        {
                            this.forSend.Add(segment.ToArray());
                        }
                        await this.socket.SendAsync(this.forSend, SocketFlags.None);
                    }
                    this.output.Reader.AdvanceTo(readResult.Buffer.End);
                }
                if (readResult.IsCompleted)
                {
                    break;
                }
                this.LastActiveTime = DateTimeOffset.UtcNow;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, $"the socket connection[{this}] failed to send");
                break;
            }
        }
        this.output.Reader.Complete();
        this.output.Writer.Complete();
    }
}