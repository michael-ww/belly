namespace Belly.Algorithm
{
    using System;

    public class LeetCode111
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int minDepth = int.MaxValue;
            if (root.Left != null)
            {
                minDepth = Math.Min(this.MinDepth(root.Left), minDepth);
            }
            if (root.Right != null)
            {
                minDepth = Math.Min(this.MinDepth(root.Right), minDepth);
            }
            return minDepth == int.MaxValue ? 1 : minDepth + 1;
        }
    }
}