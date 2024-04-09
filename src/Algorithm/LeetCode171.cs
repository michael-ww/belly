namespace Belly.Algorithm
{
    using System;

    public class LeetCode171
    {
        public int TitleToNumber(string columnTitle)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(columnTitle);
            int answer = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                int num = columnTitle[i] - 'A' + 1;
                answer = answer * 26 + num;
            }

            return answer;
        }
    }
}