namespace Belly.Algorithm
{
    using System;

    public class QuickSorting
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
                int randomIndex = leftIndex + Random.Shared.Next(rightIndex - leftIndex + 1);
                Utility.Swap(nums, rightIndex, randomIndex);
                (int middleLeft, int middleRight) = this.Partition(nums, leftIndex, rightIndex);
                this.Process(nums, leftIndex, middleLeft - 1);
                this.Process(nums, middleRight + 1, rightIndex);
            }
        }

        public (int, int) Partition(int[] nums, int leftIndex, int rightIndex)
        {
            int lessPosition = leftIndex - 1;
            int morePosition = rightIndex;
            while (leftIndex < morePosition)
            {
                if (nums[leftIndex] > nums[rightIndex])
                {
                    Utility.Swap(nums, leftIndex, --morePosition);
                }
                else if (nums[leftIndex] < nums[rightIndex])
                {
                    Utility.Swap(nums, leftIndex++, ++lessPosition);
                }
                else
                {
                    leftIndex++;
                }
            }
            Utility.Swap(nums, rightIndex, morePosition);
            return (lessPosition + 1, morePosition);
        }
    }
}