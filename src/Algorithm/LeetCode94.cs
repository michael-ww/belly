namespace Belly.Algorithm
{
    using System.Collections.Generic;

    public class LeetCode94
    {
        public IList<int> InorderTraversal1(TreeNode root)
        {
            List<int> answer = new();
            if (root == null)
            {
                return answer;
            }
            this.InorderTraversal(answer, root);
            return answer;
        }

        private void InorderTraversal(IList<int> list, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            this.InorderTraversal(list, root.Left);
            list.Add(root.Value);
            this.InorderTraversal(list, root.Right);
        }

        public IList<int> InorderTraversal2(TreeNode root)
        {
            List<int> answer = new();
            if (root == null)
            {
                return answer;
            }

            Stack<TreeNode> stack = new();
            while (stack.Count > 0 || root != null)
            {
                if (root == null)
                {
                    root = stack.Pop();
                    answer.Add(root.Value);
                    root = root.Right;
                }
                else
                {
                    stack.Push(root);
                    root = root.Left;
                }
            }

            return answer;
        }

        public IList<int> InorderTraversal3(TreeNode root)
        {
            List<int> answer = new();
            if (root == null)
            {
                return answer;
            }

            TreeNode current = root;
            TreeNode mostRight = null;
            while (current != null)
            {
                mostRight = current.Left;
                if (mostRight != null)
                {
                    while (mostRight.Right != null && mostRight.Right != current)
                    {
                        mostRight = mostRight.Right;
                    }
                    if (mostRight.Right == null)
                    {
                        mostRight.Right = current;
                        current = current.Left;
                        continue;
                    }
                    else
                    {
                        mostRight.Right = null;
                    }
                }
                answer.Add(current.Value);
                current = current.Right;
            }

            return answer;

        }
    }
}