namespace Belly.Algorithm
{
    public class LeetCode720
    {
        public string LongestWord(string[] words)
        {
            ArgumentNullException.ThrowIfNull(words);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(words.Length);

            Trie trie = new();
            foreach (var item in words)
            {
                trie.Insert(item);
            }
            string answer = string.Empty;
            foreach (var item in words)
            {
                if (this.Search(trie.Root, item))
                {
                    if (item.Length > answer.Length)
                    {
                        answer = item;
                    }
                    else if (item.Length == answer.Length)
                    {
                        answer = answer.CompareTo(item) > 0 ? item : answer;
                    }
                }
            }
            return answer;
        }

        private bool Search(TrieNode root, string word)
        {
            TrieNode current = root;
            foreach (var ch in word)
            {
                if (!current.Nexts.ContainsKey(ch) || current.Nexts[ch].End <= 0)
                {
                    return false;
                }
                current = current.Nexts[ch];
            }
            return current.End > 0;
        }
    }
}