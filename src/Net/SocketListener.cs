namespace Belly.Net
{
    using System.Net;
    using System.Net.Sockets;

    public class SocketListener
    {
        private Socket socket;

        private readonly IPEndPoint localEndPoint;

        public SocketListener(string ip, int port)
        {
            this.localEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        }

        public void Start()
        {
            this.socket = new Socket(this.localEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            this.socket.Bind(this.localEndPoint);
            this.socket.Listen(100);
        }
    }
}