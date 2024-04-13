namespace Belly.Algorithm
{
    public class LeetCode136
    {
        public int SingleNumber(int[] nums)
        {
            ArgumentNullException.ThrowIfNull(nums);
            if (nums.Length < 2)
            {
                return nums[0];
            }

            int eor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                eor ^= nums[i];
            }

            return eor;
        }
    }
}