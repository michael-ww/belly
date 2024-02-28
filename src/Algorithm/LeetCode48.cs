namespace Algorithm
{
    using System.Linq;

    public class LeetCode48
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length <= 0)
            {
                return;
            }

            int n = matrix.GetLength(0);
            int[][] help = new int[matrix.GetLength(1)][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                }
            }

            // for (int i = 0; i < n; ++i)
            // {
            //     for (int j = 0; j < n; ++j)
            //     {
            //         matrix_new[j][n - i - 1] = matrix[i][j];
            //     }
            // }
            // for (int i = 0; i < n; ++i)
            // {
            //     for (int j = 0; j < n; ++j)
            //     {
            //         matrix[i][j] = matrix_new[i][j];
            //     }
            // }
        }
    }
}