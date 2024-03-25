namespace Belly.Algorithm
{
    public class MergeSorting
    {
        public void Process(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return;
            }
            this.Process(nums, 0, nums.Length - 1);
        }

        public void Process(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
                this.Process(nums, leftIndex, middleIndex);
                this.Process(nums, middleIndex + 1, rightIndex);
                this.Merge(nums, leftIndex, middleIndex, rightIndex);
            }
        }

        public void Merge(int[] nums, int leftIndex, int middleIndex, int rightIndex)
        {
            int[] orderedArray = new int[rightIndex - leftIndex + 1];
            int orderedArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1;
            while (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
            {
                orderedArray[orderedArrayIndex++] = nums[leftHelpIndex] <= nums[rightHelpIndex] ? nums[leftHelpIndex++] : nums[rightHelpIndex++];
            }
            while (leftHelpIndex <= middleIndex)
            {
                orderedArray[orderedArrayIndex++] = nums[leftHelpIndex++];
            }
            while (rightHelpIndex <= rightIndex)
            {
                orderedArray[orderedArrayIndex++] = nums[rightHelpIndex++];
            }

            for (int i = 0; i < orderedArray.Length; i++)
            {
                nums[leftIndex + i] = orderedArray[i];
            }
        }
    }
}