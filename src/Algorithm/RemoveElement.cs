namespace Algorithm;

public class RemoveElement
{
    public int Process(int[] nums, int target)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }

        int fastIndex = 0, slowIndex = -1;
        while (fastIndex < nums.Length)
        {
            if (nums[fastIndex] != target)
            {
                slowIndex++;
                nums[slowIndex] = nums[fastIndex];
            }
            fastIndex++;
        }
        return slowIndex + 1;
    }
}