namespace Belly.Algorithm
{
    public class LeetCode138
    {
        public RdmListNode CopyRandomList1(RdmListNode head)
        {
            if (head == null)
            {
                return null;
            }
            Dictionary<RdmListNode, RdmListNode> dictionary = new();
            RdmListNode current = head;
            while (current != null)
            {
                dictionary.Add(current, new RdmListNode(current.Value));
                current = current.Next;
            }
            current = head;
            while (current != null)
            {
                dictionary[current].Next = current.Next == null ? null : dictionary[current.Next];
                dictionary[current].Random = current.Random == null ? null : dictionary[current.Random];
                current = current.Next;
            }

            return dictionary[head];
        }

        public RdmListNode CopyRandomList2(RdmListNode head)
        {
            if (head == null)
            {
                return null;
            }
            RdmListNode current = head;
            while (current != null)
            {
                RdmListNode next = current.Next;
                current.Next = new RdmListNode(current.Value); ;
                current.Next.Next = next;
                current = next;
            }

            current = head;
            while (current != null)
            {
                current.Next.Random = current.Random?.Next;
                current = current.Next?.Next;
            }

            RdmListNode answer = head.Next;
            current = head;
            while (current != null)
            {
                RdmListNode next = current.Next.Next;
                RdmListNode copy = current.Next;
                current.Next = next;
                copy.Next = next.Next;
                current = next;
            }

            return answer;
        }
    }
}