namespace Belly.Algorithm
{
    public class LeetCode111
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftMinDepth = this.MinDepth(root.Left);
            int rightMinDepth = this.MinDepth(root.Right);
            return Math.Min(leftMinDepth, rightMinDepth) + 1;
        }
    }
}