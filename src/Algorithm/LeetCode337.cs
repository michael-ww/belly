namespace Belly.Algorithm
{
    public class LeetCode337
    {
        public int Rob(TreeNode root)
        {
            (int robbing, int notRobbing) = this.Process(root);
            return Math.Max(notRobbing, robbing);
        }

        private (int, int) Process(TreeNode current)
        {
            if (current == null)
            {
                return (0, 0);
            }

            (int leftRobbing, int leftNotRobbing) = this.Process(current.Left);
            (int rightRobbing, int rightNotRobbing) = this.Process(current.Right);
            int robbing = leftNotRobbing + rightNotRobbing + current.Value;
            int notRobbing = Math.Max(leftNotRobbing, leftRobbing) + Math.Max(rightNotRobbing, rightRobbing);
            return (robbing, notRobbing);
        }
    }
}