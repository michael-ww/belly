namespace Belly.Algorithm
{
    public class LeetCode53
    {
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        public int MaxSubArray1(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return 0;
            }
            int answer = nums[0], previous = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                previous = Math.Max(previous, previous + nums[i]);
                answer = Math.Max(answer, previous);
            }

            return answer;
        }

        public int MaxSubArray2(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return 0;
            }

            return 0;
        }
    }
}