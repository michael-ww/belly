namespace Belly.Algorithm
{
    public class LeetCode21
    {
        public ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            ListNode previous = new(0);
            ListNode current = previous;
            while (list1 != null || list2 != null)
            {
                if (list2 == null || (list1 != null && list1.Value < list2.Value))
                {
                    current.Next = new(list1.Value);
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = new(list2.Value);
                    list2 = list2.Next;
                }
                current = current.Next;
            }
            return previous.Next;
        }

        public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }
            else if (list1.Value < list2.Value)
            {
                list1.Next = this.MergeTwoLists2(list1.Next, list2);
                return list1;
            }
            else
            {
                list2.Next = this.MergeTwoLists2(list1, list2.Next);
                return list2;
            }
        }
    }
}