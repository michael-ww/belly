namespace Algorithm
{
    using System;
    using System.Collections.Generic;

    public class ThreeSum
    {
        public IList<Tuple<int, int, int>> Process(int[] nums)
        {
            if (nums == null || nums.Length < 3)
            {
                return new List<Tuple<int, int, int>>();
            }
            Array.Sort(nums);
            List<Tuple<int, int, int>> answer = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int rightIndex = nums.Length - 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    while (j < rightIndex && nums[i] + nums[j] + nums[rightIndex] > 0)
                    {
                        rightIndex--;
                    }
                    if (j == rightIndex)
                    {
                        break;
                    }
                    if (nums[i] + nums[j] + nums[rightIndex] == 0)
                    {
                        answer.Add(Tuple.Create(nums[i], nums[j], nums[rightIndex]));
                    }
                }
            }

            return answer;
        }
    }
}