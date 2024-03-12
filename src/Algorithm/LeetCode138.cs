namespace Algorithm
{
    using System.Collections.Generic;

    public class LeetCode138
    {
        public RandomListNode CopyRandomList1(RandomListNode head)
        {
            if (head == null)
            {
                return null;
            }
            Dictionary<RandomListNode, RandomListNode> dictionary = new();
            RandomListNode current = head;
            while (current != null)
            {
                dictionary.Add(current, new RandomListNode(current.Value));
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

        public RandomListNode CopyRandomList2(RandomListNode head)
        {
            if (head == null)
            {
                return null;
            }
            RandomListNode current = head;
            while (current != null)
            {
                RandomListNode next = current.Next;
                current.Next = new RandomListNode(current.Value); ;
                current.Next.Next = next;
                current = next;
            }

            current = head;
            while (current != null)
            {
                current.Next.Random = current.Random?.Next;
                current = current.Next?.Next;
            }

            RandomListNode answer = head.Next;
            current = head;
            while (current != null)
            {
                RandomListNode next = current.Next.Next;
                RandomListNode copy = current.Next;
                current.Next = next;
                copy.Next = next.Next;
                current = next;
            }

            return answer;
        }
    }
}