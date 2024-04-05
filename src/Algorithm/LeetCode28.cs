namespace Belly.Algorithm
{
    public class LeetCode28
    {
        public int StrStr1(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack) || string.IsNullOrWhiteSpace(needle))
            {
                return -1;
            }
            return haystack.IndexOf(needle);
        }

        public int StrStr2(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack) || string.IsNullOrWhiteSpace(needle))
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                int a = 0, b = 0;
                while (b < needle.Length && haystack[a] == needle[b])
                {
                    a++;
                    b++;
                }
                if (b == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }

        public int StrStr3(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack) || string.IsNullOrWhiteSpace(needle))
            {
                return -1;
            }

            return -1;
        }
    }
}