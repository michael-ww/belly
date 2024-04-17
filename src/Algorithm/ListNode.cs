namespace Belly.Algorithm
{
    public class ListNode : IComparable<ListNode>
    {
        public int Value { get; set; }

        public ListNode Next { get; set; }

        public ListNode(int value = 0, ListNode next = null)
        {
            this.Value = value;
            this.Next = next;
        }

        public int CompareTo(ListNode other)
        {
            return this.Value - other.Value;
        }
    }
}