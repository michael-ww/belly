namespace Belly.Algorithm
{
    //Time Complexity : O(N)
    //Space Complexity: O(1)
    public class LeetCode206
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }
            ListNode previous = null, current = head;
            while (current != null)
            {
                ListNode currentNext = current.Next;
                current.Next = previous;
                previous = current;
                current = currentNext;
            }
            return previous;
        }
    }
}