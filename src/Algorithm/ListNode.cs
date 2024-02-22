namespace Algorithm;

public class ListNode
{
    public int Value { get; }

    public ListNode Next { get; set; }

    public ListNode(int val = 0, ListNode next = null)
    {
        this.Value = val;
        this.Next = next;
    }
}