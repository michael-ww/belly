namespace Belly.Algorithm
{
    using System;

    public class Sorting
    {
        public void SelectionSort(int[] array)
        {
            if (array == null || array.Length <= 0)
            {
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void InsertionSort(int[] array)
        {
            if (array == null || array.Length <= 0)
            {
                return;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void BubbleSort(int[] array)
        {
            if (array == null || array.Length <= 0)
            {
                return;
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void MergeSort(int[] array)
        {
            if (array == null || array.Length <= 0)
            {
                throw new ArgumentException();
            }
            this.Process(array, 0, array.Length - 1);
        }

        private void Process(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex == rightIndex)
            {
                return;
            }

            int middleIndex = leftIndex + ((rightIndex - leftIndex) >> 1);
            Process(array, leftIndex, middleIndex);
            Process(array, middleIndex + 1, rightIndex);
            Merge(array, leftIndex, middleIndex, rightIndex);
        }

        private void Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int[] orderedArray = new int[rightIndex - leftIndex + 1];
            int orderedArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1;
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
                    else
                    {
                        orderedArray[orderedArrayIndex] = array[leftHelpIndex];
                        orderedArrayIndex++;
                        leftHelpIndex++;
                    }
                }
                else
                {
                    if (leftHelpIndex > middleIndex)
                    {
                        orderedArray[orderedArrayIndex] = array[rightHelpIndex];
                        orderedArrayIndex++;
                        rightHelpIndex++;
                    }
                    else
                    {
                        orderedArray[orderedArrayIndex] = array[leftHelpIndex];
                        orderedArrayIndex++;
                        leftHelpIndex++;
                    }
                }
            }

            for (int i = 0; i < orderedArray.Length; i++)
            {
                array[leftIndex + i] = orderedArray[i];
            }
        }

        public void QuickSort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }
            this.QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int randomIndex = leftIndex + Random.Shared.Next(rightIndex - leftIndex + 1);
                Utility.Swap(array, randomIndex, rightIndex);
                int[] indexes = this.Partition(array, leftIndex, rightIndex);
                this.QuickSort(array, leftIndex, indexes[0] - 1);
                this.QuickSort(array, indexes[1] + 1, rightIndex);
            }
        }

        private int[] Partition(int[] array, int leftIndex, int rightIndex)
        {
            int less = leftIndex - 1;
            int more = rightIndex;
            while (leftIndex < more)
            {
                if (array[leftIndex] < array[rightIndex])
                {
                    less++;
                    Utility.Swap(array, less, leftIndex);
                    leftIndex++;
                }
                else if (array[leftIndex] > array[rightIndex])
                {
                    more--;
                    Utility.Swap(array, more, leftIndex);
                }
                else
                {
                    leftIndex++;
                }
            }
            Utility.Swap(array, more, rightIndex);
            return new int[] { less + 1, more };
        }

        public void HeapSort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                this.HeapInsert(array, i);
            }
            int heapSize = array.Length;
            Utility.Swap(array, 0, --heapSize);
            while (heapSize > 0)
            {
                this.Heapify(array, 0, heapSize);
                Utility.Swap(array, 0, --heapSize);
            }
        }

        private void HeapInsert(int[] array, int index)
        {
            while (index >= 0 && array[index] > array[(index - 1) / 2])
            {
                Utility.Swap(array, index, (index - 1) / 2);
                index = (index - 1) / 2;
            }
        }

        private void Heapify(int[] array, int index, int heapSize)
        {
            int leftIndex = (index * 2) + 1;
            while (leftIndex < heapSize)
            {
                int largest = (leftIndex + 1 < heapSize && array[leftIndex] < array[leftIndex + 1]) ? leftIndex + 1 : leftIndex;
                largest = array[largest] > array[index] ? largest : index;
                if (largest == index)
                {
                    break;
                }
                Utility.Swap(array, largest, index);
                index = largest;
                leftIndex = (index * 2) + 1;
            }
        }

        public void RadixSort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }
            int digit = this.GetMaxBits(array);
            this.RadixSort(array, 0, array.Length, digit);
        }

        public void RadixSort(int[] array, int leftIndex, int rightIndex, int digit)
        {
            int radix = 10;
            int[] bucket = new int[rightIndex - leftIndex + 1];
            for (int d = 1; d <= digit; d++)
            {
                int[] count = new int[radix];
                int i, j;
                for (i = leftIndex; i <= rightIndex; i++)
                {
                    j = this.GetDigit(array[i], d);
                    count[j]++;
                }
                for (i = 1; i < radix; i++)
                {
                    count[i] = count[i] + count[i - 1];
                }
                for (i = rightIndex; i >= leftIndex; i--)
                {
                    j = this.GetDigit(array[i], d);
                    bucket[count[j] - 1] = array[i];
                    count[j]--;
                }
                for (i = leftIndex, j = 0; i < rightIndex; i++, j++)
                {
                    array[i] = bucket[j];
                }
            }
        }

        public int GetDigit(int x, int d)
        {
            return x / (int)Math.Pow(10, d - 1) % 10;
        }

        public int GetMaxBits(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }
            int result = 0;
            while (max != 0)
            {
                result++;
                max /= 10;
            }

            return result;
        }
    }
}