namespace Belly.Algorithm
{
    public class LeetCode162
    {
        public int FindPeakElement(int[] nums)
        {
            ArgumentNullException.ThrowIfNull(nums);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nums.Length);
            if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }
            else
            {
                if (nums[0] > nums[1])
                {
                    return nums[0];
                }
                else if (nums[^1] > nums[^2])
                {
                    return nums[^1];
                }
                else
                {
                    int leftIndex = 0, rightIndex = nums.Length - 1;
                    while (leftIndex < rightIndex)
                    {
                        int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
                        if (nums[middleIndex] < nums[middleIndex + 1])
                        {
                            leftIndex = middleIndex + 1;
                        }
                        else
                        {
                            rightIndex = middleIndex;
                        }
                    }

                    return leftIndex;
                }
            }
        }
    }
}