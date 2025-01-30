namespace Belly.Protocol;

using System;

public interface IMessageEncoder<T>
{
    public byte[] Encode(T message);
}