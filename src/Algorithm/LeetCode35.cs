namespace Belly.Algorithm
{
    public class LeetCode35
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null)
            {
                return -1;
            }

            int leftIndex = 0, rightIndex = nums.Length - 1;
            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (nums[middleIndex] < target)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex - 1;
                }
            }

            return leftIndex;
        }
    }
}