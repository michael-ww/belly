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
            int minValue = int.MinValue;
            return this.IsValidBST(root, ref minValue);
        }

        private bool IsValidBST(TreeNode root, ref int previousValue)
        {
            if (root == null)
            {
                return true;
            }
            bool isLeftValidBST = this.IsValidBST(root.Left, ref previousValue);
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
            return this.IsValidBST(root.Right, ref previousValue);
        }

        public bool IsValidBST2(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            Stack<TreeNode> stack = new();
            int previousValue = int.MinValue;
            while (stack.Count > 0 || root != null)
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
                    stack.Push(root);
                    root = root.Left;
                }
            }

            return true;
        }

        public bool IsValidBST3(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            int previous = int.MinValue;
            TreeNode current = root;
            while (current != null)
            {
                TreeNode mostRight = current.Left;
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
                if (current.Value <= previous)
                {
                    return false;
                }
                previous = current.Value;
                current = current.Right;
            }

            return true;
        }
    }
}