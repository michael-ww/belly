namespace Belly.Algorithm
{
    public class LeetCode337
    {
        public int Rob(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            (int rootRobbing, int rootNotRobbing) = this.Process(root);
            return Math.Max(rootNotRobbing, rootRobbing);
        }

        private (int, int) Process(TreeNode tn)
        {
            if (tn == null)
            {
                return (0, 0);
            }

            (int leftRobbing, int leftNotRobbing) = this.Process(tn.Left);
            (int rightRobbing, int rightNotRobbing) = this.Process(tn.Right);
            int tnRobbing = leftNotRobbing + rightNotRobbing + tn.Value;
            int tnNotRobbing = Math.Max(leftNotRobbing, leftRobbing) + Math.Max(rightNotRobbing, rightRobbing);
            return (tnRobbing, tnNotRobbing);
        }
    }
}