namespace Belly.Algorithm
{
    public class LeetCode47
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> answer = new List<IList<int>>();
            if (nums == null || nums.Length <= 0)
            {
                return answer;
            }
            Array.Sort(nums);
            bool[] checking = new bool[nums.Length];
            this.Backtrack(answer, new List<int>(nums), nums, 0, checking);
            return answer;
        }

        private void Backtrack(IList<IList<int>> answer, IList<int> output, int[] nums, int index, bool[] checking)
        {
            if (index >= nums.Length)
            {
                answer.Add(new List<int>(output));
                return;
            }
            for (int i = index; i < nums.Length; i++)
            {
                if (checking[i] || (i > 0 && nums[i] == nums[i - 1] && !checking[i - 1]))
                {
                    continue;
                }
                output.Add(nums[i]);
                checking[i] = true;
                this.Backtrack(answer, output, nums, index + 1, checking);
                output.Remove(nums[i]);
                checking[i] = false;
            }
        }
    }
}