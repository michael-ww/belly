namespace Belly.Net;

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class SocketListener(SocketServerConfig config, ILogger logger) : IListener
{
    private readonly SocketServerConfig config = config;
    private readonly ILogger logger = logger;
    private Socket listener;
    public event Action<Socket> OnNewClientConnected;

    public void Start()
    {
        try
        {
            this.listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
            this.listener.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            this.listener.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, false);
            this.listener.LingerState = new LingerOption(false, 0);
            this.listener.Bind(new IPEndPoint(string.IsNullOrEmpty(this.config.IP) ? IPAddress.Any : IPAddress.Parse(this.config.IP), this.config.Port));
            this.listener.Listen(100);
            Task.Run(() => this.AcceptAsync());
            this.logger.LogInformation($"the socket listener[{this.listener.LocalEndPoint}] started");
        }
        catch (Exception ex)
        {
            this.logger.LogError(ex, $"the socket listener[{this}] failed to start");
        }

    }

    public void Stop()
    {
        try
        {
            this.listener?.Shutdown(SocketShutdown.Both);
        }
        catch
        {
        }
        finally
        {
            this.listener?.Close();
        }
    }

    private async Task AcceptAsync()
    {
        while (true)
        {
            try
            {
                Socket socket = await this.listener.AcceptAsync();
                this.OnNewClientConnected?.Invoke(socket);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, $"the socket listener[{this.listener.LocalEndPoint}] failed to accept");
                break;
            }
        }
    }
}