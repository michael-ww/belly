namespace Belly.Net;

public class SocketServerConfig
{
    public string IP { get; set; }

    public int Port { get; set; }

    public int MaxConnectionCount { get; set; } = 1000000;

    public int ReceiveBufferSize { get; set; } = 1024 * 1024;

    public int SendBufferSize { get; set; } = 64 * 1024;

    public int ReceiveTimeout { get; set; } = 1000;

    public int SendTimeout { get; set; } = 1000;

    public int BlockSize { get; set; } = 4096;
}