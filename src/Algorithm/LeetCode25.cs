namespace Belly.Algorithm
{
    public class LeetCode25
    {

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || head.Next == null || k < 2)
            {
                return head;
            }

            ListNode dummy = new(0)
            {
                Next = head
            };
            ListNode current = head, previous = dummy;
            while (current != null)
            {
                int nodeCount = k;
                ListNode start = current;
                while (nodeCount > 0 && current != null)
                {
                    nodeCount--;
                    current = current.Next;
                }
                if (nodeCount > 0)
                {
                    break;
                }
                ListNode next = current.Next;
                current.Next = null;
                previous.Next = this.Reverse(start);
                start.Next = next;
                previous = start;
                current = next;
            }

            return dummy.Next;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode previous = null, current = head;
            while (current != null)
            {
                ListNode next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }
    }
}