namespace Algorithm;

public class AddTwoNumbers
{
    public ListNode AddTwoNums(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null)
        {
            throw new ArgumentException();
        }
        if (l1 == null)
        {
            return l2;
        }
        if (l2 == null)
        {
            return l1;
        }
        ListNode head = new ListNode(0, null);
        ListNode current = head;
        int carryNumber = 0;
        while (l1 != null || l2 != null)
        {
            int x = l1 == null ? 0 : l1.Value;
            int y = l2 == null ? 0 : l2.Value;
            int z = x + y + carryNumber;
            current.Next = new ListNode(z % 10, null);
            current = current.Next;
            carryNumber = z / 10;
            if (l1 != null)
            {
                l1 = l1.Next;
            }
            if (l2 != null)
            {
                l2 = l2.Next;
            }
        }

        if (carryNumber > 0)
        {
            current = new ListNode(carryNumber, null);
        }
        return head.Next;
    }

    public class ListNode
    {
        public int Value { get; }
        public ListNode Next { get; set; }

        public ListNode(int value, ListNode next)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}