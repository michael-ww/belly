namespace Algorithm
{
    using System;
    using System.Collections.Generic;

    public class FourSum
    {
        public IList<Tuple<int, int, int, int>> Process(int[] nums, int target)
        {
            if (nums == null || nums.Length < 4)
            {
                throw new ArgumentException();
            }
            Array.Sort(nums);
            List<Tuple<int, int, int, int>> answer = new();
            if (nums[0] + nums[1] + nums[2] + nums[3] > target)
            {
                return answer;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int leftIndex = j + 1, rightIndex = nums.Length - 1;
                    while (leftIndex < rightIndex)
                    {
                        if (leftIndex > j + 1 && nums[leftIndex] == nums[leftIndex - 1])
                        {
                            leftIndex++;
                            continue;
                        }
                        if (rightIndex - 1 > leftIndex && nums[rightIndex] == nums[rightIndex - 1])
                        {
                            rightIndex--;
                            continue;
                        }
                        int sum = nums[i] + nums[j] + nums[leftIndex] + nums[rightIndex];
                        if (sum > target)
                        {
                            rightIndex--;
                        }
                        else if (sum < target)
                        {
                            leftIndex++;
                        }
                        else
                        {
                            answer.Add(Tuple.Create(nums[i], nums[j], nums[leftIndex], nums[rightIndex]));
                            rightIndex--;
                            leftIndex++;
                        }
                    }
                }
            }

            return answer;
        }
    }
}