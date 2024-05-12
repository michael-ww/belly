namespace Belly.Algorithm
{
    public class LeetCode29
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException(nameof(divisor));
            }

            return int.MinValue;
        }
    }
}