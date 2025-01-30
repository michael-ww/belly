namespace Belly.Test
{
    using System;
    using System.Buffers;
    using System.Text;
    using System.Linq;
    using Belly.Net;
    using Belly.Protocol;
    using Microsoft.Extensions.Logging;

    class Program
    {
        static void Main(string[] args)
        {
            SocketServerConfig config = new()
            {
                Port = 8080,
                MaxConnectionCount = 1
            };
            SocketServer socketServer = new(config, LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Information)).CreateLogger<SocketServer>());
            socketServer.OnMessageReceived += (connection, buffer) =>
            {
                CommandLineDecoder decoder = new();
                decoder.Decode(buffer.ToArray()).ToList().ForEach(line => Console.WriteLine(line));
                CommandLineEncoder encoder = new();
                connection.SendAsync(encoder.Encode($"Hello {connection.RemoteEndPoint}"));
                return buffer.End;
            };
            socketServer.Start();
            Console.ReadLine();
        }
    }
}
