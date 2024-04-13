namespace Belly.Algorithm
{
    public class LeetCode486
    {
        public bool PredictTheWinner1(int[] nums)
        {
            if (nums == null || nums.Length <= 2)
            {
                return true;
            }
            return this.PredictTheWinner1(nums, 0, nums.Length - 1) >= 0;
        }

        private int PredictTheWinner1(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return 0;
            }

            int leftScore = nums[leftIndex] - this.PredictTheWinner1(nums, leftIndex + 1, rightIndex);
            int rightScore = nums[rightIndex] - this.PredictTheWinner1(nums, leftIndex, rightIndex - 1);
            return Math.Max(leftScore, rightScore);
        }


        public bool PredictTheWinner2(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return true;
            }

            int[,] dp = new int[nums.Length, nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return this.PredictTheWinner2(nums, 0, nums.Length - 1, dp) >= 0;
        }

        public int PredictTheWinner2(int[] nums, int leftIndex, int rightIndex, int[,] dp)
        {
            if (leftIndex > rightIndex)
            {
                return 0;
            }

            if (dp[leftIndex, rightIndex] != -1)
            {
                return dp[leftIndex, rightIndex];
            }

            int leftScore = nums[leftIndex] - this.PredictTheWinner2(nums, leftIndex + 1, rightIndex, dp);
            int rightScore = nums[rightIndex] - this.PredictTheWinner2(nums, leftIndex, rightIndex - 1, dp);
            dp[leftIndex, rightIndex] = Math.Max(leftScore, rightScore);

            return dp[leftIndex, rightIndex];
        }

        public bool PredictTheWinner3(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return true;
            }

            int[,] dp = new int[nums.Length, nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i, i] = nums[i];
            }

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);
                }
            }

            return dp[0, nums.Length - 1] >= 0;
        }
    }
}