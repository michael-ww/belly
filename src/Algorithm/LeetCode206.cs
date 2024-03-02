namespace Algorithm
{
    public class LeetCode206
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            ListNode previous = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode temp = current.Next;
                current.Next = previous;
                previous = current;
                current = temp;
            }

            return previous;
        }
    }
}