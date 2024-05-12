namespace Belly.Algorithm
{
    public class LeetCode33
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length <= 0)
            {
                return -1;
            }
            int leftIndex = 0, rightIndex = nums.Length - 1;
            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (nums[middleIndex] > target)
                {
                    if (nums[leftIndex] < nums[middleIndex] && nums[leftIndex] <= target)
                    {
                        rightIndex = middleIndex - 1;
                    }
                    else
                    {
                        leftIndex = middleIndex + 1;
                    }
                }
                else if (nums[middleIndex] < target)
                {
                    if (nums[middleIndex] < nums[rightIndex] && nums[rightIndex] >= target)
                    {
                        leftIndex = middleIndex + 1;
                    }
                    else
                    {
                        rightIndex = middleIndex - 1;
                    }
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