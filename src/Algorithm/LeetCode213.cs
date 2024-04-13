namespace Belly.Algorithm
{
    public class LeetCode213
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            else
            {
                int previous = nums[0];
                int current1 = Math.Max(nums[0], nums[1]);
                for (int i = 2; i < nums.Length - 1; i++)
                {
                    int robbing = Math.Max(nums[i] + previous, current1);
                    previous = current1;
                    current1 = robbing;
                }

                previous = nums[1];
                int current2 = Math.Max(nums[1], nums[2]);
                for (int i = 3; i < nums.Length; i++)
                {
                    int robbing = Math.Max(nums[i] + previous, current2);
                    previous = current2;
                    current2 = robbing;
                }

                return Math.Max(current1, current2);
            }
        }
    }
}