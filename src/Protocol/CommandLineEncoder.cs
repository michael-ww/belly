namespace Belly.Protocol;

using System.Text;

public class CommandLineEncoder(Encoding encoding = null) : IMessageEncoder<string>
{
    private readonly Encoding encoding = encoding ?? Encoding.UTF8;

    public byte[] Encode(string message)
    {
        return this.encoding.GetBytes($"{message}\n");
    }
}