namespace Belly.Algorithm
{
    public class LeetCode162
    {
        public int FindPeakElement(int[] nums)
        {
            ArgumentNullException.ThrowIfNull(nums);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nums.Length);
            if (nums.Length == 1 || nums[0] > nums[1])
            {
                return 0;
            }
            if (nums[^1] > nums[^2])
            {
                return nums.Length - 1;
            }
            int leftIndex = 1, rightIndex = nums.Length - 2;
            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
                if (nums[middleIndex] < nums[middleIndex - 1])
                {
                    rightIndex = middleIndex - 1;
                }
                else if (nums[middleIndex] < nums[middleIndex + 1])
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    return middleIndex;
                }
            }

            return -1;
        }


    }
}