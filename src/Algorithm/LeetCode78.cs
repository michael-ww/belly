namespace Belly.Algorithm
{
    public class LeetCode78
    {
        public List<List<int>> Subsets1(int[] nums)
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

        public List<List<int>> Subsets2(int[] nums)
        {
            List<List<int>> answer = new();
            if (nums == null || nums.Length <= 0)
            {
                return answer;
            }
            this.DFS(nums, 0, [], answer);
            return answer;
        }

        public void DFS(int[] nums, int index, IList<int> path, List<List<int>> answer)
        {
            if (index >= nums.Length)
            {
                answer.Add(new List<int>(path));
            }
            else
            {
                path.Add(nums[index]);
                this.DFS(nums, index + 1, path, answer);
                path.Remove(nums[index]);
                this.DFS(nums, index + 1, path, answer);
            }
        }
    }
}