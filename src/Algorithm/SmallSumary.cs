namespace Algorithm
{
    using System;

    public class SmallSumary
    {
        public int Calculate(int[] array)
        {
            if (array == null || array.Length <= 0)
            {
                throw new ArgumentException();
            }
            return this.Process(array, 0, array.Length - 1);
        }

        private int Process(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex == rightIndex)
            {
                return 0;
            }
            int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
            int leftSum = Process(array, leftIndex, middleIndex);
            int rightSum = Process(array, middleIndex + 1, rightIndex);
            int mergeSum = Merge(array, leftIndex, middleIndex, rightIndex);
            return leftSum + rightSum + mergeSum;

        }

        private int Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int[] orderedArray = new int[rightIndex - leftIndex + 1];
            int orderedArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1, smallSum = 0;
            while (leftHelpIndex <= middleIndex || rightHelpIndex <= rightIndex)
            {
                if (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
                {
                    if (array[leftHelpIndex] > array[rightHelpIndex])
                    {
                        orderedArray[orderedArrayIndex] = array[rightHelpIndex];
                        orderedArrayIndex++;
                        rightHelpIndex++;
                    }
                    else if (array[leftHelpIndex] < array[rightHelpIndex])
                    {
                        smallSum += array[leftHelpIndex] * (rightIndex - rightHelpIndex + 1);
                        orderedArray[orderedArrayIndex] = array[leftHelpIndex];
                        orderedArrayIndex++;
                        leftHelpIndex++;
                    }
                    else
                    {
                        orderedArray[orderedArrayIndex] = array[rightHelpIndex];
                        orderedArrayIndex++;
                        rightHelpIndex++;
                    }
                }
                else if (leftHelpIndex > middleIndex)
                {
                    orderedArray[orderedArrayIndex] = array[rightHelpIndex];
                    orderedArrayIndex++;
                    rightHelpIndex++;
                }
                else if (rightHelpIndex > rightIndex)
                {
                    orderedArray[orderedArrayIndex] = array[leftHelpIndex];
                    orderedArrayIndex++;
                    leftHelpIndex++;
                }
            }

            for (int i = 0; i < orderedArray.Length; i++)
            {
                array[leftIndex + i] = orderedArray[i];
            }

            return smallSum;
        }
    }
}