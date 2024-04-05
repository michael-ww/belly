namespace Belly.Algorithm
{
    using System.Collections.Generic;

    public class LeetCode100
    {
        public bool IsSameTree1(TreeNode p, TreeNode q)
        {
            if (p == null)
            {
                return q == null;
            }
            if (q == null)
            {
                return false;
            }
            if (p.Value != q.Value)
            {
                return false;
            }

            return this.IsSameTree1(p.Left, q.Left) && this.IsSameTree1(p.Right, q.Right);
        }

        public bool IsSameTree2(TreeNode p, TreeNode q)
        {
            if (p == null)
            {
                return q == null;
            }
            if (q == null)
            {
                return false;
            }
            if (p.Value != q.Value)
            {
                return false;
            }

            Queue<TreeNode> pQueue = new();
            pQueue.Enqueue(p);
            Queue<TreeNode> qQueue = new();
            qQueue.Enqueue(q);
            while (pQueue.Count > 0 && qQueue.Count > 0)
            {
                TreeNode ptn = pQueue.Dequeue();
                TreeNode qtn = qQueue.Dequeue();
                if (ptn.Value != qtn.Value)
                {
                    return false;
                }
                if (ptn.Left == null)
                {
                    return qtn.Left == null;
                }
                if (qtn.Left == null)
                {
                    return false;
                }
                if (ptn.Right == null)
                {
                    return qtn.Right == null;
                }
                if (qtn.Right == null)
                {
                    return false;
                }
                pQueue.Enqueue(ptn.Left);
                pQueue.Enqueue(ptn.Right);
                qQueue.Enqueue(qtn.Left);
                qQueue.Enqueue(qtn.Right);
            }

            return pQueue.Count == 0 && qQueue.Count == 0;
        }
    }
}