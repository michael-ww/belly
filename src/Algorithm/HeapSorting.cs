namespace Algorithm
{
    //Time Complexity : O(NlogN)
    //Space Complexity : O(1)
    public class HeapSorting
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                this.HeapInsert(nums, i);
            }
            int heapSize = nums.Length;
            Utility.Swap(nums, 0, --heapSize);
            while (heapSize > 0)
            {
                this.Heapify(nums, 0, heapSize);
                Utility.Swap(nums, 0, --heapSize);
            }
        }

        private void HeapInsert(int[] nums, int index)
        {
            while (nums[index] > nums[(index - 1) / 2])
            {
                Utility.Swap(nums, (index - 1) / 2, index);
                index = (index - 1) / 2;
            }
        }

        private void Heapify(int[] nums, int index, int heapSize)
        {
            int leftIndex = index * 2 + 1;
            while (leftIndex < heapSize)
            {
                int largestIndex = leftIndex + 1 < heapSize && nums[leftIndex + 1] > nums[leftIndex] ? leftIndex + 1 : leftIndex;
                largestIndex = nums[largestIndex] > nums[index] ? largestIndex : index;
                if (largestIndex == index)
                {
                    break;
                }
                Utility.Swap(nums, index, largestIndex);
                index = largestIndex;
                leftIndex = index * 2 + 1;
            }
        }
    }
}