namespace Belly.Algorithm
{
    public class SearchRange
    {
        public Tuple<int, int> Process(int[] nums, int target)
        {
            if (nums == null)
            {
                return Tuple.Create(-1, -1);
            }

            int leftIndex = 0, rightIndex = nums.Length - 1, startIndex = -1, endIndex = -1;
            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
                if (nums[middleIndex] == target)
                {
                    rightIndex = middleIndex - 1;
                    startIndex = middleIndex;
                }
                else if (nums[middleIndex] > target)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            leftIndex = 0;
            rightIndex = nums.Length - 1;
            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
                if (nums[middleIndex] == target)
                {
                    leftIndex = middleIndex + 1;
                    endIndex = middleIndex;
                }
                else if (nums[middleIndex] > target)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return Tuple.Create(startIndex, endIndex);
        }
    }
}