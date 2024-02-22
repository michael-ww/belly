namespace Algorithm;

public class RemoveDuplicates
{
    public int Process(int[] nums)
    {
        if (nums == null)
        {
            return 0;
        }
        if (nums.Length < 2)
        {
            return nums.Length;
        }
        int iteratorIndex = 1, distinctIndex = 1;
        while (iteratorIndex < nums.Length)
        {
            if (nums[iteratorIndex] != nums[iteratorIndex - 1])
            {
                nums[distinctIndex] = nums[iteratorIndex];
                distinctIndex++;
            }
            iteratorIndex++;
        }
        return distinctIndex;
    }
}