namespace Belly.Protocol;

using System;
using System.Collections.Generic;
using System.Text;

public class CommandLineDecoder(Encoding encoding = null) : IMessageDecoder<IEnumerable<string>>
{
    private readonly Encoding encoding = encoding ?? Encoding.UTF8;

    public IEnumerable<string> Decode(byte[] buffer)
    {
        string text = this.encoding.GetString(buffer);
        string[] lines = text.Trim().Split('\n', StringSplitOptions.RemoveEmptyEntries);
        return lines;
    }
}