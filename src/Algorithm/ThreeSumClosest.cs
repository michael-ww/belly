namespace Belly.Algorithm
{
    public class ThreeSumClosest
    {
        public int Process(int[] nums, int target)
        {
            if (nums == null || nums.Length < 3)
            {
                throw new ArgumentException();
            }

            Array.Sort(nums);
            int closetTarget = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int j = i + 1, k = nums.Length - 1;
                while (j < nums.Length - 1 && j < k)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        continue;
                    }
                    if (k < nums.Length - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }
                    int sum = nums[i] + nums[j] + nums[k];
                    if (Math.Abs(sum - target) < Math.Abs(closetTarget - target))
                    {
                        closetTarget = sum;
                    }
                    if (sum == target)
                    {
                        return target;
                    }
                    else if (sum > target)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return closetTarget;
        }
    }
}