namespace Belly.Algorithm
{


    public class PalindromeList
    {
        public bool IsPalindrome1(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Next == null)
            {
                return true;
            }

            Stack<ListNode> stack = new();
            ListNode current = head;
            while (current != null)
            {
                stack.Push(current);
                current = current.Next;
            }

            while (head != null)
            {
                if (head.Value != stack.Pop().Value)
                {
                    return false;
                }
                head = head.Next;
            }
            return true;
        }

        public bool IsPalindrome2(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Next == null)
            {
                return true;
            }

            ListNode fastNode = head;
            ListNode slowNode = head;
            while (fastNode.Next != null && fastNode.Next.Next != null)
            {
                slowNode = slowNode.Next;
                fastNode = fastNode.Next.Next;
            }

            fastNode = slowNode.Next;
            slowNode.Next = null;
            ListNode ln = null;
            while (fastNode != null)
            {
                ln = fastNode.Next;
                fastNode.Next = slowNode;
                slowNode = fastNode;
                fastNode = ln;
            }
            return true;
        }
    }
}