namespace Algorithm
{
    public class InsertionSorting
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[j + 1] < nums[j])
                    {
                        Utility.Swap(nums, j, j + 1);
                    }
                }
            }
        }
    }
}