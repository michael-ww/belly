namespace Belly.Algorithm
{
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
                pq.Enqueue(lists[i], lists[i].Value);
            }

            ListNode head = pq.Dequeue();
            pq.Enqueue(head.Next, head.Next.Value);
            ListNode current = head;
            while (pq.Count > 0)
            {
                current.Next = pq.Dequeue();
                if (current.Next.Next != null)
                {
                    pq.Enqueue(current.Next.Next, current.Next.Next.Value);
                }
                current = current.Next;
            }

            return head;
        }
    }
}