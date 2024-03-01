namespace Algorithm
{
    public class SmallSumary
    {

        public int Process(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
            {
                return 0;
            }
            return this.Process(nums, 0, nums.Length - 1);
        }


        public int Process(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex == rightIndex)
            {
                return 0;
            }

            int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
            int leftSumary = this.Process(nums, leftIndex, middleIndex);
            int rightSumary = this.Process(nums, middleIndex + 1, rightIndex);
            int mergeSumary = this.Merge(nums, leftIndex, middleIndex, rightIndex);
            return leftSumary + rightSumary + mergeSumary;
        }

        public int Merge(int[] nums, int leftIndex, int middleIndex, int rightIndex)
        {
            int[] helpArray = new int[rightIndex - leftIndex + 1];
            int helpArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1, samllSumary = 0;
            while (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
            {
                if (nums[leftHelpIndex] < nums[rightHelpIndex])
                {
                    samllSumary += nums[leftHelpIndex] * (rightIndex - rightHelpIndex + 1);
                    helpArray[helpArrayIndex] = nums[leftHelpIndex];
                    helpArrayIndex++;
                    leftHelpIndex++;
                }
                else
                {
                    helpArray[helpArrayIndex] = nums[rightHelpIndex];
                    helpArrayIndex++;
                    rightHelpIndex++;
                }
            }

            while (leftHelpIndex <= middleIndex)
            {
                helpArray[helpArrayIndex] = nums[leftHelpIndex];
                helpArrayIndex++;
                leftHelpIndex++;
            }

            while (rightHelpIndex <= rightIndex)
            {
                helpArray[helpArrayIndex] = nums[rightHelpIndex];
                helpArrayIndex++;
                rightHelpIndex++;
            }

            for (int i = 0; i < helpArray.Length; i++)
            {
                nums[leftIndex + i] = helpArray[i];
            }

            return samllSumary;
        }
        // public int Calculate(int[] array)
        // {
        //     if (array == null || array.Length <= 0)
        //     {
        //         throw new ArgumentException();
        //     }
        //     return this.Process(array, 0, array.Length - 1);
        // }

        // private int Process(int[] array, int leftIndex, int rightIndex)
        // {
        //     if (leftIndex == rightIndex)
        //     {
        //         return 0;
        //     }
        //     int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
        //     int leftSum = Process(array, leftIndex, middleIndex);
        //     int rightSum = Process(array, middleIndex + 1, rightIndex);
        //     int mergeSum = Merge(array, leftIndex, middleIndex, rightIndex);
        //     return leftSum + rightSum + mergeSum;

        // }

        // private int Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        // {
        //     int[] orderedArray = new int[rightIndex - leftIndex + 1];
        //     int orderedArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1, smallSum = 0;
        //     while (leftHelpIndex <= middleIndex || rightHelpIndex <= rightIndex)
        //     {
        //         if (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
        //         {
        //             if (array[leftHelpIndex] > array[rightHelpIndex])
        //             {
        //                 orderedArray[orderedArrayIndex] = array[rightHelpIndex];
        //                 orderedArrayIndex++;
        //                 rightHelpIndex++;
        //             }
        //             else if (array[leftHelpIndex] < array[rightHelpIndex])
        //             {
        //                 smallSum += array[leftHelpIndex] * (rightIndex - rightHelpIndex + 1);
        //                 orderedArray[orderedArrayIndex] = array[leftHelpIndex];
        //                 orderedArrayIndex++;
        //                 leftHelpIndex++;
        //             }
        //             else
        //             {
        //                 orderedArray[orderedArrayIndex] = array[rightHelpIndex];
        //                 orderedArrayIndex++;
        //                 rightHelpIndex++;
        //             }
        //         }
        //         else if (leftHelpIndex > middleIndex)
        //         {
        //             orderedArray[orderedArrayIndex] = array[rightHelpIndex];
        //             orderedArrayIndex++;
        //             rightHelpIndex++;
        //         }
        //         else if (rightHelpIndex > rightIndex)
        //         {
        //             orderedArray[orderedArrayIndex] = array[leftHelpIndex];
        //             orderedArrayIndex++;
        //             leftHelpIndex++;
        //         }
        //     }

        //     for (int i = 0; i < orderedArray.Length; i++)
        //     {
        //         array[leftIndex + i] = orderedArray[i];
        //     }

        //     return smallSum;
        // }
    }
}