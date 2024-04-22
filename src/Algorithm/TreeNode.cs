namespace Belly.Algorithm
{
    public class TreeNode : IComparable<TreeNode>
    {
        public int Value { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public TreeNode Next { get; set; }

        public TreeNode(int value) { this.Value = value; }


        public int CompareTo(TreeNode other)
        {
            return this.Value - other.Value;
        }
    }
}