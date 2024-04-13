namespace Belly.Algorithm
{
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

        private bool IsValidBST(TreeNode root, int previousValue)
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

        public bool IsBST3(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            int previousValue = int.MinValue;
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
                    else if (mostRight.Right == current)
                    {
                        mostRight.Right = null;
                    }
                }
                if (current.Value <= previousValue)
                {
                    return false;
                }
                previousValue = current.Value;
                current = current.Right;
            }

            return true;
        }
    }
}