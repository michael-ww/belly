namespace Belly.Algorithm
{
    using System;

    public class LeetCode374
    {
        private int number;

        public int GuessNumber(int n)
        {
            this.number = Random.Shared.Next(n + 1);
            int left = 1, right = n, answer = 0;
            while (left <= right)
            {
                int middle = left + ((right - left) >> 1);
                int comparing = this.guess(middle);
                if (comparing > 0)
                {
                    left = middle + 1;
                }
                else if (comparing < 0)
                {
                    right = middle - 1;
                }
                else
                {
                    answer = middle;
                    break;
                }
            }
            return answer;
        }

        private int guess(int num)
        {
            return this.number.CompareTo(num);
        }
    }
}