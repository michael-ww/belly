namespace Belly.Algorithm
{
    public class LeetCode46
    {
        // Time Complexity: O(n*n!)
        // Space Complexity: O(n)
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> answer = new();
            if (nums == null || nums.Length <= 0)
            {
                return answer;
            }
            this.Backtrack(nums, 0, new List<int>(nums), answer);
            return answer;
        }

        private void Backtrack(int[] nums, int index, IList<int> output, IList<IList<int>> answer)
        {
            if (index >= nums.Length)
            {
                answer.Add(new List<int>(output));
                return;
            }
            for (int i = index; i < nums.Length; i++)
            {
                Utility.Swap(output, i, index);
                this.Backtrack(nums, index + 1, output, answer);
                Utility.Swap(output, i, index);
            }
        }
    }
}