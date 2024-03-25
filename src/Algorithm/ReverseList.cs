namespace Belly.Algorithm;

public class ReverseList
{

    public ListNode Process(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }
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

    public ListNode Process(ListNode head, int left, int right)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        ListNode dummyNode = new ListNode(-1);
        dummyNode.Next = head;
        ListNode previous = dummyNode;
        for (int i = 0; i < left - 1; i++)
        {
            previous = previous.Next;
        }

        ListNode current = previous.Next;
        ListNode next;
        for (int i = 0; i < right - left; i++)
        {
            next = current.Next;
            current.Next = next.Next;
            next.Next = previous.Next;
            previous.Next = next;
        }
        return dummyNode.Next;
    }
}