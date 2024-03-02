namespace Algorithm
{
    public class RotatingArraySearch
    {
        public int Process(int[] nums, int target)
        {
            if (nums == null || nums.Length <= 0)
            {
                return -1;
            }

            int leftIndex = 0, rightIndex = nums.Length - 1;
            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
                if (nums[middleIndex] == target)
                {
                    return middleIndex;
                }
                if (nums[leftIndex] <= nums[middleIndex])
                {
                    if (nums[leftIndex] <= target && target < nums[middleIndex])
                    {
                        rightIndex = middleIndex - 1;
                    }
                    else
                    {
                        leftIndex = middleIndex + 1;
                    }
                }
                else
                {
                    if (nums[middleIndex] < target && target <= nums[rightIndex])
                    {
                        leftIndex = middleIndex + 1;
                    }
                    else
                    {
                        rightIndex = middleIndex - 1;
                    }
                }
            }
            return -1;
        }

    }
}