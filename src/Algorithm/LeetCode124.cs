namespace Belly.Algorithm
{
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

            (int leftDistance, int leftHeight) = this.Process(root.Left);
            (int rightDistance, int rightHeight) = this.Process(root.Right);
            int rootDistance = leftHeight + rightHeight + 1;
            int distance = Math.Max(rootDistance, Math.Max(leftDistance, rightDistance));
            int height = Math.Max(leftHeight, rightHeight) + 1;
            return (distance, height);
        }
    }
}