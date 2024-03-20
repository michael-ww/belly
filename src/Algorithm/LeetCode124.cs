namespace Algorithm
{
    using System;

    public class LeetCode124
    {
        public int MaxPathSum(TreeNode root)
        {
            return root == null ? 0 : this.Process(root).Item1;
        }

        private (int, int) Process(TreeNode root)
        {
            if (root == null)
            {
                return (0, 0);
            }

            (int leftMaxDistance, int leftHeight) = this.Process(root.Left);
            (int rightMaxDistance, int rightHeight) = this.Process(root.Right);
            int rootMaxDistance = leftHeight + rightHeight + 1;
            int distance = Math.Max(rootMaxDistance, Math.Max(leftMaxDistance, rightMaxDistance));
            int height = Math.Max(leftHeight, rightHeight) + 1;
            return (distance, height);
        }
    }
}