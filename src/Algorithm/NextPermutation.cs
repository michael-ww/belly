namespace Belly.Algorithm
{
    public class NextPermutation
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return;
            }
            int i = nums.Length - 2, j = nums.Length - 1, k = nums.Length - 1;
            while (i >= 0 && nums[i] >= nums[j])
            {
                i--;
                j--;
            }
            if (i >= 0)
            {
                while (k >= 0 && nums[i] >= nums[k])
                {
                    k--;
                }
                Utility.Swap(nums, i, k);
                Utility.Reverse(nums, i + 1, nums.Length - 1);
            }
            else
            {
                Utility.Reverse(nums, 0, nums.Length - 1);
            }

        }
    }
}