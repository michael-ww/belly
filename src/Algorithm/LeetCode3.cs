namespace Algorithm
{
    using System;
    using System.Collections.Generic;

    public class LeetCode3
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            int answer = 0;
            Dictionary<char, int> dictionary = new();
            int leftIndex = 0, rightIndex = 0;
            while (rightIndex < s.Length)
            {
                if (dictionary.TryGetValue(s[rightIndex], out int index))
                {
                    answer = Math.Max(answer, rightIndex - leftIndex);
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