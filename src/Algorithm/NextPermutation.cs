namespace Algorithm
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
                this.Swap(nums, i, k);
                this.Reverse(nums, i + 1, nums.Length - 1);
            }
            else
            {
                this.Reverse(nums, 0, nums.Length - 1);
            }

        }
        private void Swap(int[] nums, int i, int j)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        private void Reverse(int[] nums, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }
            startIndex = startIndex < 0 ? 0 : startIndex;
            endIndex = endIndex > nums.Length - 1 ? nums.Length - 1 : endIndex;
            while (startIndex < endIndex)
            {
                this.Swap(nums, startIndex, endIndex);
                startIndex++;
                endIndex--;
            }
        }
    }
}