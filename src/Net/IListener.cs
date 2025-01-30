namespace Belly.Net;

using System;
using System.Net.Sockets;

internal interface IListener
{
    event Action<Socket> OnNewClientConnected;
    void Start();
    void Stop();
}