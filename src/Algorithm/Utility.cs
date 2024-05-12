namespace Belly.Algorithm;

public static class Utility
{
    public static void Swap<T>(T[] nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    public static void Swap<T>(IList<T> nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    public static void Reverse<T>(T[] nums, int startIndex, int endIndex)
    {
        if (startIndex >= endIndex)
        {
            return;
        }
        startIndex = startIndex < 0 ? 0 : startIndex;
        endIndex = endIndex > nums.Length - 1 ? nums.Length - 1 : endIndex;
        while (startIndex < endIndex)
        {
            Utility.Swap(nums, startIndex, endIndex);
            startIndex++;
            endIndex--;
        }
    }

    public static ListNode Reverse(ListNode head)
    {
        if (head == null || head.Next == null)
        {
            return head;
        }

        ListNode current = head, previous = null;
        while (current != null)
        {
            ListNode temp = current.Next;
            current.Next = previous;
            previous = current;
            current = temp;
        }
        return previous;
    }
}