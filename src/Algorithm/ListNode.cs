namespace Belly.Algorithm
{
    public class ListNode
    {
        public int Value { get; }

        public ListNode Next { get; set; }

        public ListNode(int value = 0, ListNode next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}