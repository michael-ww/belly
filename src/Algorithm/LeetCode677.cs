namespace Belly.Algorithm
{
    public class MapSum
    {
        private readonly TrieNode root;

        public MapSum()
        {
            this.root = new TrieNode();
        }

        public void Insert(string key, int val)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return;
            }
            TrieNode current = root;
            current.Pass++;
            foreach (var ch in key)
            {
                if (!current.Nexts.ContainsKey(ch))
                {
                    current.Nexts.Add(ch, new TrieNode());
                }
                current = current.Nexts[ch];
                current.Pass++;
            }
            current.End++;
            current.Value = val;
        }

        public int Sum(string prefix)
        {
            if (string.IsNullOrWhiteSpace(prefix))
            {
                return 0;
            }

            int answer = 0;
            TrieNode current = root;
            foreach (var ch in prefix)
            {
                if (!current.Nexts.ContainsKey(ch))
                {
                    return answer;
                }
                current = current.Nexts[ch];
            }
            this.DFS(current.Nexts, ref answer);
            return answer;
        }

        private void DFS(Dictionary<char, TrieNode> Nexts, ref int answer)
        {
            if (Nexts == null || Nexts.Count <= 0)
            {
                return;
            }

            foreach (var item in Nexts)
            {
                answer += item.Value.Value.GetValueOrDefault();
                this.DFS(item.Value.Nexts, ref answer);
            }
        }
    }
}