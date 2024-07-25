namespace Belly.Algorithm
{
    public class QuickSort
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return;
            }
            this.Process(nums, 0, nums.Length - 1);
        }

        public void Process(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivotIndex = Random.Shared.Next(leftIndex, rightIndex + 1);
                (int pivotLeftIndex, int pivotRightIndex) = this.Partition(nums, leftIndex, rightIndex, nums[pivotIndex]);
                this.Process(nums, leftIndex, pivotLeftIndex - 1);
                this.Process(nums, pivotRightIndex + 1, rightIndex);
            }
        }

        public (int, int) Partition(int[] nums, int leftIndex, int rightIndex, int pivot)
        {
            int cursor = leftIndex;
            while (cursor <= rightIndex)
            {
                if (nums[cursor] > pivot)
                {
                    Utility.Swap(nums, cursor, rightIndex--);
                }
                else if (nums[cursor] < pivot)
                {
                    Utility.Swap(nums, cursor++, leftIndex++);
                }
                else
                {
                    cursor++;
                }
            }
            return (leftIndex, rightIndex);
        }
    }
}