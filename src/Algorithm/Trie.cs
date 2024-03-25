namespace Belly.Algorithm
{
    using System.Collections.Generic;

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            this.root = new();
        }

        public void Insert(string word)
        {
            if (word is null)
            {
                return;
            }

            char[] charactors = word.ToCharArray();
            TrieNode current = root;
            current.Pass++;
            for (int i = 0; i < charactors.Length; i++)
            {
                int offset = charactors[i] - 'a';
                if (current.Nexts[offset] is null)
                {
                    current.Nexts[offset] = new TrieNode();
                }
                current = current.Nexts[offset];
                current.Pass++;
            }
            current.End++;
        }

        public int Search(string word)
        {
            if (word is null)
            {
                return 0;
            }

            char[] charactors = word.ToCharArray();
            TrieNode current = root;
            for (int i = 0; i < charactors.Length; i++)
            {
                int offset = charactors[i] - 'a';
                if (current.Nexts[offset] == null)
                {
                    return 0;
                }
                current = current.Nexts[offset];
            }
            return current.End;
        }

        public int Prefix(string word)
        {
            if (word is null)
            {
                return 0;
            }

            char[] charactors = word.ToCharArray();
            TrieNode current = root;
            for (int i = 0; i < charactors.Length; i++)
            {
                int offset = charactors[i] - 'a';
                if (current.Nexts[offset] is null)
                {
                    return 0;
                }
                current = current.Nexts[offset];
            }

            return current.Pass;
        }

        public void Delete(string word)
        {
            if (word is null)
            {
                return;
            }
            if (this.Search(word) <= 0)
            {
                return;
            }

            char[] charactors = word.ToCharArray();
            TrieNode current = root;
            current.Pass--;
            for (int i = 0; i < charactors.Length; i++)
            {
                int offset = charactors[i] - 'a';
                if (--current.Nexts[offset].Pass == 0)
                {
                    current.Nexts[offset] = null;
                    return;
                }
                current = current.Nexts[offset];
            }

            current.End--;
        }
    }

    public class TrieNode
    {
        public int Pass { get; set; }

        public int End { get; set; }

        public TrieNode[] Nexts { get; set; }

        // public SortedDictionary<char,TrieNode> Nexts{ get; set; }

        public TrieNode()
        {
            this.Pass = 0;
            this.End = 0;
            this.Nexts = new TrieNode[26];
        }
    }
}