namespace Belly.Algorithm
{
    using System;

    public class TwoOddTimeNumber
    {
        public (int, int) Process(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                throw new ArgumentException("nums is null or the length of nums is less than zero");
            }

            int eor1 = 0;
            foreach (int item in nums)
            {
                eor1 ^= item;
            }

            int rightOne = eor1 & (~eor1 + 1);

            int eor2 = 0;
            foreach (int item in nums)
            {
                if ((item & rightOne) == 0)
                {
                    eor2 ^= item;
                }
            }

            return (eor1 ^ eor2, eor2);
        }
    }
}