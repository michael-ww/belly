namespace Belly.Algorithm
{
    public class LeetCode79
    {
        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length <= 0)
            {
                return false;
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (this.DFS(board, i, j, word, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool DFS(char[][] board, int row, int column, string word, int index)
        {
            if (index >= word.Length)
            {
                return true;
            }
            if (row < 0 || row >= board.Length || column < 0 || column >= board[row].Length || board[row][column] == '*' || board[row][column] != word[index])
            {
                return false;
            }

            char letter = board[row][column];
            board[row][column] = '*';
            bool left = this.DFS(board, row, column - 1, word, index + 1);
            bool right = this.DFS(board, row, column + 1, word, index + 1);
            bool up = this.DFS(board, row - 1, column, word, index + 1);
            bool down = this.DFS(board, row + 1, column, word, index + 1);
            board[row][column] = letter;
            return left || right || up || down;
        }
    }
}