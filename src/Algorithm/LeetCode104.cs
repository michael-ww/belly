namespace Belly.Algorithm
{
    using System;

    public class LeetCode104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = this.MaxDepth(root.Left);
                int rightHeight = this.MaxDepth(root.Right);
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }
    }
}