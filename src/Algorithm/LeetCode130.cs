namespace Belly.Algorithm
{
    public class LeetCode130
    {
        public void Solve(char[,] board)
        {
            ArgumentNullException.ThrowIfNull(board);
            if (board.Length <= 0)
            {
                return;
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    bool edge = i == 0 || j == 0 || (i == board.GetLength(0) - 1) || (j == board.GetLength(1) - 1);
                    if (edge && board[i, j] == '#')
                    {
                        this.BFS(board, i, j);
                    }
                }
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'O')
                    {
                        board[i, j] = 'X';
                    }
                    if (board[i, j] == '#')
                    {
                        board[i, j] = 'O';
                    }
                }
            }
        }

        private void BFS(char[,] board, int x, int y)
        {
            if (x < 0 || y < 0 || x >= board.GetLength(0) || y >= board.GetLength(1) || board[x, y] == '#' || board[x, y] == 'X')
            {
                return;
            }

            board[x, y] = '#';
            this.BFS(board, x + 1, y);
            this.BFS(board, x, y + 1);
            this.BFS(board, x - 1, y);
            this.BFS(board, x, y - 1);
        }
    }
}