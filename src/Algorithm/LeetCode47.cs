namespace Belly.Algorithm
{
    public class LeetCode47
    {
        // Time Complexity: O(n!*n)
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> answer = new List<IList<int>>();
            if (nums == null || nums.Length <= 0)
            {
                return answer;
            }
            this.Backtrack(nums, 0, answer);
            return answer;
        }

        private void Backtrack(int[] nums, int index, IList<IList<int>> answer)
        {
            if (index >= nums.Length)
            {
                answer.Add(new List<int>(nums));
            }
            else
            {
                HashSet<int> hs = new();
                for (int i = index; i < nums.Length; i++)
                {
                    if (!hs.Contains(nums[i]))
                    {
                        hs.Add(nums[i]);
                        Utility.Swap(nums, i, index);
                        this.Backtrack(nums, index + 1, answer);
                        Utility.Swap(nums, i, index);
                    }
                }
            }
        }
    }
}