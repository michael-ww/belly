namespace Belly.Algorithm
{
    using System;
    using System.Collections.Generic;

    public class LeetCode1
    {
        public (int, int) TwoSum1(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return (-1, -1);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1);
        }

        public (int, int) TwoSum2(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return (-1, -1);
            }

            Dictionary<int, int> cache = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (cache.ContainsKey(target - nums[i]))
                {
                    return (cache[target - nums[i]], i);
                }
                else
                {
                    cache.Add(nums[i], i);
                }
            }

            return (-1, -1);
        }

        public (int, int) TowSum3(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return (-1, -1);
            }

            Array.Sort(nums);
            int leftIndex = 0, rightIndex = nums.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (nums[leftIndex] + nums[rightIndex] == target)
                {
                    return (leftIndex, rightIndex);
                }
                else if (nums[leftIndex] + nums[rightIndex] > target)
                {
                    rightIndex--;
                }
                else
                {
                    leftIndex++;
                }
            }

            return (-1, -1);
        }
    }
}