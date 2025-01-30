namespace Belly.Protocol;

public interface IMessageDecoder<T>
{
    public T Decode(byte[] buffer);
}