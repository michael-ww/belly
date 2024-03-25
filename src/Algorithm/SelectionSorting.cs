namespace Belly.Algorithm
{
    public class SelectionSort
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        Utility.Swap(nums, i, j);
                    }
                }
            }
        }
    }
}