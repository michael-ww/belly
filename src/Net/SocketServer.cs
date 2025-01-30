namespace Belly.Net;

using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;

public class SocketServer
{
    private readonly SocketServerConfig config;
    private readonly ILogger logger;
    private IListener listener;
    private readonly ConcurrentQueue<IConnection> connections;
    public event Func<IConnection, ReadOnlySequence<byte>, SequencePosition> OnMessageReceived;

    public SocketServer(SocketServerConfig config, ILogger logger)
    {
        this.config = config;
        this.logger = logger;
        this.connections = new();
        for (int i = 0; i < this.config.MaxConnectionCount; i++)
        {
            SocketConnection connection = new(this.config, this.logger);
            connection.OnMessageReceived += this.Connection_OnMessageReceived;
            connection.OnDisconnected += this.Connection_OnDisconnected;
            this.connections.Enqueue(connection);
        }
    }

    public void Start()
    {
        this.listener = new SocketListener(this.config, this.logger);
        this.listener.OnNewClientConnected += this.SocketListener_OnNewClientConnected;
        this.listener.Start();
    }

    public void Stop()
    {
        this.listener.Stop();
        while (this.connections.TryDequeue(out IConnection connection))
        {
            connection.Dispose();
        }
        this.logger.LogInformation($"the socket server[{this}] stopped");
    }

    private async void SocketListener_OnNewClientConnected(Socket socket)
    {
        if (this.connections.TryDequeue(out IConnection connection))
        {
            await connection.AcceptAsync(socket);
            this.connections.Enqueue(connection);
        }
        else
        {
            this.logger.LogWarning($"the socket connection pool is reached the maximum capacity[{this.config.MaxConnectionCount}],Socket client[{socket.RemoteEndPoint}] will be aborted");
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }

    private SequencePosition Connection_OnMessageReceived(IConnection connection, ReadOnlySequence<byte> sequence)
    {
        return this.OnMessageReceived?.Invoke(connection, sequence) ?? sequence.End;
    }

    private void Connection_OnDisconnected(IConnection connection)
    {
        this.logger.LogInformation($"the socket connection[{connection.ID}] disconnected");
    }
}