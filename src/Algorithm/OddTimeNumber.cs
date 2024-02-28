namespace Algorithm
{
    using System;

    public class OddTimeNumber
    {
        public int Process(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                throw new ArgumentException();
            }

            int eor = 0;
            foreach (var item in nums)
            {
                eor ^= item;
            }

            return eor;
        }
    }
}