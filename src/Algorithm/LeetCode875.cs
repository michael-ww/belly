namespace Belly.Algorithm
{
    public class LeetCode875
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            ArgumentNullException.ThrowIfNull(piles);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(h);

            int low = 1, high = 0;
            foreach (var item in piles)
            {
                high = Math.Max(high, item);
            }

            int answer = 0;
            while (low <= high)
            {
                int middle = low + ((high - low) >> 1);
                int hour = this.GetTime(piles, middle);
                if (hour <= h)
                {
                    answer = middle;
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return answer;
        }

        private int GetTime(int[] piles, int speed)
        {
            int time = 0;
            foreach (var item in piles)
            {
                time += (item + speed - 1) / speed;
            }
            return time;
        }
    }
}