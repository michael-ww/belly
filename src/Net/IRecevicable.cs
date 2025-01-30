namespace Belly.Net;

using System;
using System.Buffers;

public interface IRecevicable
{
    public event Func<IConnection, ReadOnlySequence<byte>, SequencePosition> OnMessageReceived;
}