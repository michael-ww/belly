namespace Belly.Algorithm
{
    public class LeetCode662
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            TreeNode currentEnd = root, nextEnd = null;
            int nodeCount = 0, maxWidth = 0;
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                    nextEnd = node.Left;
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                    nextEnd = node.Right;
                }
                nodeCount++;
                if (node == currentEnd)
                {
                    maxWidth = Math.Max(maxWidth, nodeCount);
                    nodeCount = 0;
                    currentEnd = nextEnd;
                    nextEnd = null;
                }
            }

            return maxWidth;
        }
    }
}