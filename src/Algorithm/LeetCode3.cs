namespace Belly.Algorithm
{
    using System.Collections.Generic;

    public class LeetCode3
    {
        public string LongestDistinctSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            string answer = string.Empty;
            Dictionary<char, int> dictionary = new();
            int leftIndex = 0, rightIndex = 0;
            while (rightIndex < s.Length)
            {
                if (dictionary.TryGetValue(s[rightIndex], out int index))
                {
                    answer = answer.Length < (rightIndex - leftIndex) ? s.Substring(leftIndex, rightIndex - leftIndex) : answer;
                    leftIndex = index + 1;
                    dictionary.Remove(s[rightIndex]);
                }
                dictionary.Add(s[rightIndex], rightIndex);
                rightIndex++;
            }
            return answer;
        }
    }
}