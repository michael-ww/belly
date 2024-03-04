namespace Algorithm
{
    using System;

    public class RadixSorting
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return;
            }
            this.Process(nums, 0, nums.Length - 1, this.GetMaxBits(nums));
        }

        public void Process(int[] nums, int leftIndex, int rightIndex, int digit)
        {
            int radix = 10;
            int[] bucket = new int[rightIndex - leftIndex + 1];
            for (int d = 1; d <= digit; d++)
            {
                int[] count = new int[radix];
                int i, j;
                for (i = leftIndex; i <= rightIndex; i++)
                {
                    j = this.GetDigit(nums[i], d);
                    count[j]++;
                }
                for (i = 1; i < radix; i++)
                {
                    count[i] = count[i] + count[i - 1];
                }
                for (i = rightIndex; i >= leftIndex; i--)
                {
                    j = this.GetDigit(nums[i], d);
                    bucket[count[j] - 1] = nums[i];
                    count[j]--;
                }
                for (i = leftIndex, j = 0; i < rightIndex; i++, j++)
                {
                    nums[i] = bucket[j];
                }
            }
        }

        private int GetMaxBits(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            int answer = 0;
            while (max != 0)
            {
                answer++;
                max /= 10;
            }
            return answer;
        }

        private int GetDigit(int x, int d)
        {
            return x / (int)Math.Pow(10, d - 1) % 10;
        }
    }
}