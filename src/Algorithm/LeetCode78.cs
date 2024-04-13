namespace Belly.Algorithm
{
    public class LeetCode78
    {
        public List<List<int>> Subsets(int[] nums)
        {
            List<List<int>> answer = new();
            if (nums == null || nums.Length <= 0)
            {
                return answer;
            }

            for (int mask = 0; mask < (1 << nums.Length); mask++)
            {
                List<int> subset = new();
                for (int i = 0; i < nums.Length; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        subset.Add(nums[i]);
                    }
                }
                answer.Add(subset);
            }

            return answer;
        }
    }
}