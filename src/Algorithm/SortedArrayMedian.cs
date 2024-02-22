namespace Algorithm;

using System;

public class SortedArrayMedian
{
    public double MergeSort(int[] array1, int[] array2)
    {
        if (array1 == null && array2 == null)
        {
            throw new ArgumentException();
        }
        if (array1 == null)
        {
            if (array2.Length <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (array2.Length % 2 == 0)
                {
                    return (array2[array2.Length / 2 - 1] + array2[array2.Length / 2]) / 2d;
                }
                else
                {
                    return array2[array2.Length / 2];
                }
            }
        }
        if (array2 == null)
        {
            if (array1.Length <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (array1.Length % 2 == 0)
                {
                    return (array1[array1.Length / 2 - 1] + array1[array1.Length / 2]) / 2d;
                }
                else
                {
                    return array1[array1.Length / 2];
                }
            }
        }

        int[] array = new int[array1.Length + array2.Length];
        int array1Index = 0, array2Index = 0, arrayIndex = 0;
        while (array1Index + array2Index < array1.Length + array2.Length)
        {
            if (array1Index >= array1.Length)
            {
                array[arrayIndex] = array2[array2Index];
                arrayIndex++;
                array2Index++;
            }
            else if (array2Index >= array2.Length)
            {
                array[arrayIndex] = array1[array1Index];
                arrayIndex++;
                array1Index++;
            }
            else
            {
                if (array1[array1Index] > array2[array2Index])
                {
                    array[arrayIndex] = array2[array2Index];
                    arrayIndex++;
                    array2Index++;
                }
                else
                {
                    array[arrayIndex] = array1[array1Index];
                    arrayIndex++;
                    array1Index++;
                }
            }
        }

        if ((array1.Length + array2.Length) % 2 == 0)
        {
            return (array[array.Length / 2 - 1] + array[array.Length / 2]) / 2d;
        }
        else
        {
            return array[array.Length / 2];
        }
    }

    public double Iterate(int[] array1, int[] array2)
    {
        if (array1 == null && array2 == null)
        {
            throw new ArgumentException();
        }
        if (array1 == null)
        {
            if (array2.Length <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (array2.Length % 2 == 0)
                {
                    return (array2[array2.Length / 2 - 1] + array2[array2.Length / 2]) / 2d;
                }
                else
                {
                    return array2[array2.Length / 2];
                }
            }
        }
        if (array2 == null)
        {
            if (array1.Length <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (array1.Length % 2 == 0)
                {
                    return (array1[array1.Length / 2 - 1] + array1[array1.Length / 2]) / 2d;
                }
                else
                {
                    return array1[array1.Length / 2];
                }
            }
        }

        int median = -1, medianPrevious = -1;
        int array1Index = 0, array2Index = 0;
        while (array1Index + array2Index <= (array1.Length + array2.Length) >> 1)
        {
            medianPrevious = median;
            if (array1Index >= array1.Length)
            {
                median = array2[array2Index];
                array2Index++;
            }
            else if (array2Index >= array2.Length)
            {
                median = array1[array1Index];
                array1Index++;
            }
            else
            {
                if (array1[array1Index] > array2[array2Index])
                {
                    median = array2[array2Index];
                    array2Index++;
                }
                else
                {
                    median = array1[array1Index];
                    array1Index++;
                }
            }
        }

        if ((array1.Length + array2.Length) % 2 == 0)
        {
            return (medianPrevious + median) / 2d;
        }
        else
        {
            return median;
        }
    }

    public double BinarySearch(int[] array1, int[] array2)
    {
        if (array1 == null && array2 == null)
        {
            throw new ArgumentException();
        }
        if (array1 == null)
        {
            if (array2.Length <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (array2.Length % 2 == 0)
                {
                    return (array2[array2.Length / 2] + array2[(array2.Length / 2) - 1]) / 2d;
                }
                else
                {
                    return array2[array2.Length / 2];
                }
            }
        }
        if (array2 == null)
        {
            if (array1.Length <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (array1.Length % 2 == 0)
                {
                    return (array1[array1.Length / 2] + array1[array1.Length / 2 - 1]) / 2d;
                }
                else
                {
                    return array1[array1.Length / 2];
                }
            }
        }

        if ((array1.Length + array2.Length) % 2 == 0)
        {
            return (this.FindKthElement(array1, array2, (array1.Length + array2.Length) / 2) + FindKthElement(array1, array2, (array1.Length + array2.Length) / 2 + 1)) / 2d;
        }
        else
        {
            return this.FindKthElement(array1, array2, ((array1.Length + array2.Length) / 2) + 1);
        }
    }

    public int FindKthElement(int[] array1, int[] array2, int kth)
    {
        if (array1 == null || array2 == null || kth <= 0)
        {
            throw new ArgumentException();
        }
        if (array1 == null)
        {
            if (array2.Length <= 0 || kth > array2.Length)
            {
                throw new ArgumentException();
            }
            else
            {
                return array2[kth - 1];
            }
        }
        if (array2 == null)
        {
            if (array1.Length <= 0 || kth > array1.Length)
            {
                throw new ArgumentException();
            }
            else
            {
                return array1[kth - 1];
            }
        }
        if (kth > array1.Length + array2.Length)
        {
            throw new ArgumentException();
        }

        int array1Index = 0, array2Index = 0;
        while (true)
        {
            if (array1Index >= array1.Length)
            {
                return array2[array2Index + kth - 1];
            }
            if (array2Index >= array2.Length)
            {
                return array1[array1Index + kth - 1];
            }
            if (kth == 1)
            {
                return Math.Min(array1[array1Index], array2[array2Index]);
            }

            int array11Index = Math.Min(array1Index + (kth / 2) - 1, array1.Length - 1);
            int array22Index = Math.Min(array2Index + kth / 2 - 1, array2.Length - 1);
            if (array1[array11Index] > array2[array22Index])
            {
                array2Index = array22Index + 1;
            }
            else
            {
                array1Index = array11Index + 1;
            }
            kth -= kth / 2;
        }
    }
}