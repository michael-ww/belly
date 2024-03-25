namespace Belly.Algorithm
{
    public class LeetCode92
    {
        public ListNode ReverseBetween1(ListNode head, int left, int right)
        {
            if (head == null || head.Next == null || left > right)
            {
                return head;
            }
            left = left < 1 ? 1 : left;
            ListNode precursor = null, leftNode = null, previousNode = null, currentNode = head;
            int nodePosition = 0;
            while (currentNode != null)
            {
                nodePosition++;
                if (nodePosition == left)
                {
                    leftNode = currentNode;
                }
                if (nodePosition < left)
                {
                    precursor = currentNode;
                    currentNode = currentNode.Next;
                }
                else if (nodePosition >= left && nodePosition <= right)
                {
                    ListNode tempNextNode = currentNode.Next;
                    currentNode.Next = previousNode;
                    previousNode = currentNode;
                    currentNode = tempNextNode;
                }
                else
                {
                    break;
                }
            }
            leftNode.Next = currentNode;
            if (left > 1)
            {
                precursor.Next = previousNode;
                return head;
            }
            else
            {
                return previousNode;
            }
        }

        public ListNode ReverseBetween2(ListNode head, int left, int right)
        {
            if (head == null || head.Next == null || left > right)
            {
                return head;
            }

            ListNode currentNode = head, leftPreviousNode = new(-1, head), previousNode = head;
            int nodePosition = 0;
            while (currentNode != null)
            {
                nodePosition++;
                if (nodePosition < left)
                {
                    leftPreviousNode = currentNode;
                    previousNode = currentNode.Next;
                    currentNode = currentNode.Next;
                }
                else if (nodePosition >= left && nodePosition <= right)
                {
                    ListNode nextNode = currentNode.Next;
                    ListNode leftNode = leftPreviousNode.Next;
                    leftPreviousNode.Next = currentNode;
                    currentNode.Next = leftNode;
                    previousNode.Next = nextNode;
                    currentNode = nextNode;
                }
                else
                {
                    break;
                }
            }
            return left == 1 ? leftPreviousNode.Next : head;
        }
    }
}