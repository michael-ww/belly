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

            for (int i = 0, minIndex; i < nums.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Utility.Swap(nums, i, minIndex);
            }
        }
    }
}