namespace Belly.Algorithm
{
    using System.Collections.Generic;

    public class LeetCode23
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length <= 0)
            {
                return null;
            }

            PriorityQueue<ListNode, int> pq = new();
            for (int i = 0; i < lists.Length; i++)
            {
                ListNode current = lists[i];
                while (current != null)
                {
                    pq.Enqueue(current, current.Value);
                    current = current.Next;
                }
            }

            ListNode previous = new(0, null);
            ListNode tail = previous;
            while (pq.Count > 0)
            {
                tail.Next = pq.Dequeue();
                tail = tail.Next;
            }

            return previous.Next;
        }
    }
}