namespace Algorithm
{
    public class FirstMissingPositive
    {
        public int Process(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return 1;
            }

            int answer = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] < answer)
                {
                    answer = nums[i];
                }
            }

            return 1;
        }
    }
}