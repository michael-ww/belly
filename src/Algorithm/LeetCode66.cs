namespace Belly.Algorithm
{
    public class LeetCode66
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length <= 0)
            {
                return new int[] { 1 };
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    return digits;
                }
            }

            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }
    }
}