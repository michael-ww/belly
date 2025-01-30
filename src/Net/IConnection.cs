namespace Belly.Net;

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

public interface IConnection : IDisposable
{
    public string ID { get; }
    public bool IsConnected { get; }
    public IPEndPoint RemoteEndPoint { get; }
    public IPEndPoint LocalEndPoint { get; }
    public DateTimeOffset LastActiveTime { get; }
    public ValueTask AcceptAsync(Socket socket);
    public ValueTask SendAsync(ReadOnlyMemory<byte> memory);
}