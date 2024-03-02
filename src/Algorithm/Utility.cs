namespace Algorithm;

public static class Utility
{
    public static void Swap(int[] nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    public static void ReverseArray(int[] nums, int startIndex, int endIndex)
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
}