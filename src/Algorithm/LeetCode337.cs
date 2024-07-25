namespace Belly.Algorithm
{
    public class LeetCode337
    {
        public int Rob(TreeNode root)
        {
            (int robbed, int notRobbing) = this.Process(root);
            return Math.Max(notRobbing, robbed);
        }

        private (int, int) Process(TreeNode current)
        {
            if (current == null)
            {
                return (0, 0);
            }

            (int leftRobbed, int leftNotRobbing) = this.Process(current.Left);
            (int rightRobbed, int rightNotRobbing) = this.Process(current.Right);
            int currentRobbed = leftNotRobbing + rightNotRobbing + current.Value;
            int currentNotRobbing = Math.Max(leftNotRobbing, leftRobbed) + Math.Max(rightNotRobbing, rightRobbed);
            return (currentRobbed, currentNotRobbing);
        }
    }
}