namespace Algorithm
{
    using System.Collections.Generic;

    public class LeetCode98
    {
        public bool IsValidBST1(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            return this.IsValidBST(root, int.MinValue);
        }

        public bool IsValidBST(TreeNode root, int previousValue)
        {
            if (root == null)
            {
                return true;
            }
            bool isLeftValidBST = this.IsValidBST(root.Left, previousValue);
            if (!isLeftValidBST)
            {
                return false;
            }
            if (root.Value <= previousValue)
            {
                return false;
            }
            else
            {
                previousValue = root.Value;
            }
            return this.IsValidBST(root.Right, previousValue);
        }

        public bool IsValidBST2(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            Stack<TreeNode> stack = new();
            int previousValue = int.MinValue;
            if (stack.Count > 0 || root != null)
            {
                if (root == null)
                {
                    root = stack.Pop();
                    if (root.Value <= previousValue)
                    {
                        return false;
                    }
                    else
                    {
                        previousValue = root.Value;
                    }
                    root = root.Right;
                }
                else
                {
                    stack.Push(root.Left);
                    root = root.Left;
                }
            }

            return true;
        }
    }
}