namespace Belly.Algorithm
{
    public class LeetCode15
    {
        public IList<(int, int, int)> ThreeSum1(int[] nums)
        {
            List<(int, int, int)> answer = [];
            if (nums == null || nums.Length <= 3)
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
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            answer.Add((nums[i], nums[j], nums[k]));
                        }
                    }
                }
            }

            return answer;
        }

        public IList<(int, int, int)> ThreeSum2(int[] nums)
        {
            List<(int, int, int)> answer = [];
            if (nums == null || nums.Length < 3)
            {
                return answer;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[j] > nums[i])
                    {
                        Utility.Swap(nums, j, i);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int leftIndex = i + 1, rightIndex = nums.Length - 1;
                while (leftIndex < rightIndex)
                {
                    if (leftIndex > i + 1 && nums[leftIndex] == nums[leftIndex - 1])
                    {
                        leftIndex++;
                        continue;
                    }
                    if (rightIndex < nums.Length - 1 && nums[rightIndex] == nums[rightIndex + 1])
                    {
                        rightIndex--;
                        continue;
                    }
                    if (nums[leftIndex] + nums[rightIndex] == -nums[i])
                    {
                        answer.Add((nums[i], nums[leftIndex], nums[rightIndex]));
                        leftIndex++;
                        rightIndex--;
                    }
                    else if (nums[leftIndex] + nums[rightIndex] > -nums[i])
                    {
                        rightIndex--;
                    }
                    else
                    {
                        leftIndex++;
                    }
                }
            }

            return answer;
        }
    }
}