namespace Belly.Algorithm
{
    public class TrieNode
    {
        public int Pass { get; set; }

        public int End { get; set; }

        public int? Value { get; set; }

        public Dictionary<char, TrieNode> Nexts { get; set; }

        public TrieNode()
        {
            this.Pass = 0;
            this.End = 0;
            this.Nexts = new Dictionary<char, TrieNode>();
        }
    }
}