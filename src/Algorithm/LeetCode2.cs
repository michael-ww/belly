namespace Belly.Algorithm
{
    public class LeetCode2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }

            ListNode answer = new ListNode(0, null);
            ListNode current = answer;
            int carryNumber = 0;
            while (l1 != null || l2 != null)
            {
                int x = l1 == null ? 0 : l1.Value;
                int y = l2 == null ? 0 : l2.Value;
                int z = x + y + carryNumber;
                current.Next = new(z % 10, null);
                carryNumber = z / 10;
                l1 = l1?.Next;
                l2 = l2?.Next;
                current = current.Next;
            }

            if (carryNumber > 0)
            {
                current.Next = new(carryNumber, null);
            }

            return answer.Next;
        }
    }
}