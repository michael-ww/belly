namespace Belly.Algorithm
{
    public class LeetCode28
    {

        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack) || string.IsNullOrWhiteSpace(needle))
            {
                return -1;
            }
            return haystack.IndexOf(needle);
        }
    }
}