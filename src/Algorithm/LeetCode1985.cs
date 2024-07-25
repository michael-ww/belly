namespace Belly.Algorithm
{
    public class LeetCode1985
    {
        public string KthLargestNumber(string[] nums, int k)
        {
            ArgumentNullException.ThrowIfNull(nums);
            Array.Sort(nums, (string s1, string s2) =>
            {
                if (s1.Length != s2.Length)
                {
                    return s1.Length - s2.Length;
                }
                else
                {
                    return string.Compare(s1, s2);
                }
            });
            return nums[^k];
        }

        private string FindKthLargestNumber(string[] nums, int leftIndex, int rightIndex, int kthIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return nums[leftIndex];
            }
            int pivotIndex = Random.Shared.Next(leftIndex, rightIndex + 1);
            (int pivotLeftIndex, int pivotRightIndex) = this.Partition(nums, leftIndex, rightIndex, int.Parse(nums[pivotIndex]));
            if (kthIndex >= pivotLeftIndex && kthIndex <= pivotRightIndex)
            {
                return nums[pivotLeftIndex];
            }
            else if (kthIndex < pivotLeftIndex)
            {
                return this.FindKthLargestNumber(nums, leftIndex, pivotLeftIndex - 1, kthIndex);
            }
            else
            {
                return this.FindKthLargestNumber(nums, pivotRightIndex + 1, rightIndex, kthIndex);
            }
        }

        private (int, int) Partition(string[] nums, int leftIndex, int rightIndex, int pivot)
        {
            int cursor = leftIndex;
            while (cursor <= rightIndex)
            {
                if (int.Parse(nums[cursor]) > pivot)
                {
                    Utility.Swap(nums, cursor, rightIndex--);
                }
                else if (int.Parse(nums[cursor]) < pivot)
                {
                    Utility.Swap(nums, cursor++, leftIndex++);
                }
                else
                {
                    cursor++;
                }
            }
            return (leftIndex, rightIndex);
        }
    }
}