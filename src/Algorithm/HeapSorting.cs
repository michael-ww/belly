namespace Belly.Algorithm
{
    using System;
    using System.Collections.Generic;
    // Time Complexity : O(NlogN)
    // Space Complexity : O(1)
    // Expansion : O(logN)
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
            while (heapSize > 0)
            {
                Utility.Swap(nums, 0, --heapSize);
                this.Heapify(nums, 0, heapSize);
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

        public void DistanceLessK(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2 || k <= 0)
            {
                return;
            }
            PriorityQueue<int, int> pq = new();
            int index1 = 0;
            for (; index1 <= Math.Min(nums.Length - 1, k); index1++)
            {
                pq.Enqueue(nums[index1], nums[index1]);
            }

            int index2 = 0;
            for (; index2 < nums.Length; index2++, index1++)
            {
                nums[index2] = pq.Dequeue();
                if (index1 < nums.Length)
                {
                    pq.Enqueue(nums[index1], nums[index1]);
                }
            }
        }
    }
}