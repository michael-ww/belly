namespace Belly.Algorithm
{
    using System;
    using System.Linq;

    public class LongestPalindromeString
    {
        public string Getlongest(string text)
        {
            if (text == null || text.Length <= 1)
            {
                return text;
            }

            int startIndex = 0, endIndex = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int length1 = this.ExpandAroundCenter(text, i, i);
                int length2 = this.ExpandAroundCenter(text, i, i + 1);
                int length = Math.Max(length1, length2);
                if (length > endIndex - startIndex)
                {
                    startIndex = i - ((length - 1) / 2);
                    endIndex = i + (length / 2);
                }
            }

            return text.Substring(startIndex, endIndex - startIndex + 1);
        }

        private int ExpandAroundCenter(string s, int leftIndex, int rightIndex)
        {
            while (leftIndex >= 0 && rightIndex < s.Length && s.ElementAt(leftIndex) == s.ElementAt(rightIndex))
            {
                leftIndex--;
                rightIndex++;
            }

            return rightIndex - leftIndex - 1;
        }
    }
}