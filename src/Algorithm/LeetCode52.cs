namespace Belly.Algorithm
{
    public class LeetCode52
    {
        public int TotalNQueens(int n)
        {
            if (n < 1)
            {
                return 0;
            }

            int[] record = new int[n];
            return this.Process(0, record, n);
        }

        public int Process(int current, int[] record, int limit)
        {
            if (current >= limit)
            {
                return 1;
            }

            int answer = 0;
            for (int j = 0; j < limit; j++)
            {

            }

            return answer;
        }
    }
}