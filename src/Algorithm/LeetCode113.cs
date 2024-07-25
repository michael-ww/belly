namespace Belly.Algorithm
{
    public class LeetCode113
    {
        public IList<IList<int>> PathSum(TreeNode root, int target)
        {
            ArgumentNullException.ThrowIfNull(root);
            List<IList<int>> answer = new();
            List<int> path = new();
            this.PathSum(answer, path, root, target);
            return answer;
        }

        private void PathSum(List<IList<int>> answer, IList<int> path, TreeNode root, int target)
        {
            if (root == null)
            {
                return;
            }
            path.Add(root.Value);
            if (root.Left == null && root.Right == null && root.Value == target)
            {
                answer.Add(new List<int>(path));
            }
            this.PathSum(answer, path, root.Left, target - root.Value);
            this.PathSum(answer, path, root.Right, target - root.Value);
            path.RemoveAt(path.Count - 1);
        }
    }
}