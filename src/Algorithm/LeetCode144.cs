namespace Algorithm
{
    using System.Collections.Generic;

    public class LeetCode144
    {
        public IList<int> PreorderTraversal1(TreeNode root)
        {
            List<int> answer = new();
            if (root == null)
            {
                return answer;
            }
            this.PreorderTraversal(answer, root);
            return answer;
        }

        public void PreorderTraversal(IList<int> list, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root.Value);
            this.PreorderTraversal(list, root.Left);
            this.PreorderTraversal(list, root.Right);
        }

        public IList<int> PreorderTraversal2(TreeNode root)
        {
            List<int> answer = new();
            if (root == null)
            {
                return answer;
            }
            Stack<TreeNode> stack = new();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                answer.Add(node.Value);
                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }
                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
            return answer;
        }

        public IList<int> PreorderTraversal3(TreeNode root)
        {
            List<int> answer = new();
            if (root == null)
            {
                return answer;
            }


            return answer;
        }
    }
}