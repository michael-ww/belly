namespace Algorithm
{
    public static class Utility
    {
        public static void Swap(int[] nums, int i, int j)
        {
            if (nums == null || nums.Length <= 0 || i < 0 || j < 0 || i > nums.Length - 1 || j > nums.Length - 1)
            {
                return;
            }

            (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        
    }
}