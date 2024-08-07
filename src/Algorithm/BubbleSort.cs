namespace Belly.Algorithm
{
    //Time Complexity : O(N*N)
    //Space Complexity : O(1)
    public class BubbleSort
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return;
            }

            for (int i = nums.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        Utility.Swap(nums, j, j + 1);
                    }
                }
            }
        }
    }
}