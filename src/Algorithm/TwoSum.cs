namespace Algorithm
{
    using System;
    using System.Collections.Generic;

    public class TwoSum
    {
        public int[] TwoSumFor(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        public int[] TwoSumCache(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException();
            }

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(target - nums[i]))
                {
                    return new int[] { dictionary[target - nums[i]], i };
                }
                else
                {
                    dictionary.Add(nums[i], i);
                }
            }
            return null;
        }

        public int[] TwoSumForSortedArray(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException();
            }

            int leftIndex = 0, rightIndex = nums.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (nums[leftIndex] + nums[rightIndex] > target)
                {
                    rightIndex--;
                }
                else if (nums[leftIndex] + nums[rightIndex] < target)
                {
                    leftIndex++;
                }
                else
                {
                    return new int[] { leftIndex, rightIndex };
                }
            }
            return null;
        }
    }
}