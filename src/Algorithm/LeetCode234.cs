namespace Belly.Algorithm
{
    using System.Collections.Generic;

    public class LeetCode234
    {
        public bool IsPalindrome1(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            ListNode current = head;
            Stack<ListNode> nodes = new();
            while (current != null)
            {
                nodes.Push(current);
                current = current.Next;
            }

            current = head;
            while (current != null)
            {
                if (nodes.Pop().Value != current.Value)
                {
                    return false;
                }
                current = current.Next;
            }

            return true;
        }

        public bool IsPalindrome2(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            ListNode fastNode = head, slowNode = head;
            while (fastNode.Next != null && fastNode.Next.Next != null)
            {
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }
            ListNode endNode = Utility.Reverse(slowNode.Next);
            ListNode leftNode = head, rightNode = endNode;
            bool answer = true;
            while (rightNode != null)
            {
                if (rightNode.Value != leftNode.Value)
                {
                    answer = false;
                    break;
                }
                leftNode = leftNode.Next;
                rightNode = rightNode.Next;
            }
            slowNode.Next = Utility.Reverse(endNode);
            return answer;
        }
    }
}