namespace Belly.Algorithm
{
    public class LeetCode113
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            ArgumentNullException.ThrowIfNull(root);
            List<IList<int>> answer = new();
            List<int> path = new();
            this.PathSum(answer, path, root, targetSum);
            return answer;
        }

        private void PathSum(List<IList<int>> answer, IList<int> path, TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return;
            }
            path.Add(root.Value);
            if (root.Left == null && root.Right == null && root.Value == targetSum)
            {
                answer.Add(new List<int>(path));
            }
            this.PathSum(answer, path, root.Left, targetSum - root.Value);
            this.PathSum(answer, path, root.Right, targetSum - root.Value);
            path.RemoveAt(path.Count - 1);
        }
    }
}