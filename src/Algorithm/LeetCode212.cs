namespace Belly.Algorithm
{
    public class LeetCode212
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            ISet<string> answer = new HashSet<string>();
            if (board == null || words == null || words.Length <= 0)
            {
                return answer.ToList();
            }
            LeetCode208 trie = new();
            foreach (var item in words)
            {
                trie.Insert(item);
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    string word = string.Empty;
                    this.DFS(board, i, j, trie.Root, word, answer);
                }
            }

            return answer.ToList();
        }

        private void DFS(char[][] board, int row, int column, TrieNode current, string word, ISet<string> answer)
        {
            if (row < 0 || row >= board.Length || column < 0 || column >= board[0].Length || board[row][column] == '*')
            {
                return;
            }
            if (!current.Nexts.ContainsKey(board[row][column]))
            {
                return;
            }
            char ch = board[row][column];
            word += ch;
            if (current.Nexts[board[row][column]].End > 0)
            {
                answer.Add(word);
                return;
            }
            current = current.Nexts[board[row][column]];
            board[row][column] = '*';
            this.DFS(board, row + 1, column, current, word, answer);
            this.DFS(board, row - 1, column, current, word, answer);
            this.DFS(board, row, column + 1, current, word, answer);
            this.DFS(board, row, column - 1, current, word, answer);
            board[row][column] = ch;
        }
    }
}