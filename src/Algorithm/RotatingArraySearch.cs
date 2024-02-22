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
            }
            return -1;
        }

    }
}