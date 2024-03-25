namespace Belly.Algorithm
{
    using System;
    using System.Collections.Generic;

    public class LeetCode215
    {
        public int FindKthLargest1(int[] nums, int k)
        {
            if (nums == null || nums.Length <= 0 || k > nums.Length)
            {
                throw new ArgumentException("nums is null or the length of nums is less then zero or the k is more than the length of nums");
            }
            Array.Sort(nums);
            return nums[^k];
        }


        public int FindKthLargest2(int[] nums, int kth)
        {
            if (nums == null || nums.Length <= 0 || kth > nums.Length)
            {
                throw new ArgumentException("nums is null or the length of nums is less then zero or the k is more than the length of nums");
            }
            return this.Select(nums, 0, nums.Length - 1, nums.Length - kth);
        }

        private int Select(int[] nums, int leftIndex, int rightIndex, int kthIndex)
        {
            if (leftIndex == rightIndex)
            {
                return nums[leftIndex];
            }
            else if (leftIndex < rightIndex)
            {
                (int lessIndex, int moreIndex) = this.Partition(nums, leftIndex, rightIndex);
                if (kthIndex < lessIndex)
                {
                    return this.Select(nums, leftIndex, lessIndex - 1, kthIndex);
                }
                else if (kthIndex >= lessIndex && kthIndex <= moreIndex)
                {
                    return nums[lessIndex];
                }
                else
                {
                    return this.Select(nums, moreIndex + 1, rightIndex, kthIndex);
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public (int, int) Partition(int[] nums, int leftIndex, int rightIndex)
        {
            int lessPosition = leftIndex - 1;
            int morePosition = rightIndex;
            int pivotIndex = leftIndex + Random.Shared.Next(rightIndex - leftIndex + 1);
            Utility.Swap(nums, rightIndex, pivotIndex);
            while (leftIndex < morePosition)
            {
                if (nums[leftIndex] < nums[rightIndex])
                {
                    lessPosition++;
                    Utility.Swap(nums, leftIndex, lessPosition);
                    leftIndex++;
                }
                else if (nums[leftIndex] > nums[rightIndex])
                {
                    morePosition--;
                    Utility.Swap(nums, leftIndex, morePosition);
                }
                else
                {
                    leftIndex++;
                }
            }
            Utility.Swap(nums, morePosition, rightIndex);
            return (lessPosition + 1, morePosition);
        }
    }
}