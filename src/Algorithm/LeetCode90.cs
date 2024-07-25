namespace Belly.Algorithm
{
    public class LeetCode90
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> answer = new();
            if (nums == null || nums.Length <= 0)
            {
                return answer;
            }
            Array.Sort(nums);
            this.DFS(nums, 0, new List<int>(), answer);
            return answer;
        }

        private void DFS(int[] nums, int index, List<int> path, IList<IList<int>> answer)
        {
            if (index >= nums.Length)
            {
                answer.Add(new List<int>(path));
            }
            else
            {
                int nextIndex = index;
                while (nextIndex < nums.Length && nums[nextIndex] == nums[index])
                {
                    nextIndex++;
                }
                this.DFS(nums, nextIndex, path, answer);
                for (int i = index; i < nextIndex; i++)
                {
                    path.Add(nums[i]);
                    this.DFS(nums, nextIndex, path, answer);
                }
            }
        }
    }
}