namespace Algorithm;

public class KInversePairs
{
    public int Calculate(int[] array)
    {
        if (array == null || array.Length < 2)
        {
            return 0;
        }
        return this.Process(array, 0, array.Length - 1);
    }

    public int Process(int[] array, int leftIndex, int rightIndex)
    {
        if (leftIndex >= rightIndex)
        {
            return 0;
        }
        int middleIndex = leftIndex + ((rightIndex - leftIndex + 1) >> 1);
        int leftCount = this.Process(array, leftIndex, middleIndex);
        int rightCount = this.Process(array, middleIndex + 1, rightIndex);
        int mergeCount = this.Merge(array, leftIndex, middleIndex, rightIndex);
        return leftCount + rightCount + mergeCount;
    }

    public int Merge(int[] array, int leftIndex, int middleIndex, int rightIndex)
    {
        int[] orderedArray = new int[rightIndex - leftIndex + 1];
        int orderedArrayIndex = 0, leftHelpIndex = leftIndex, rightHelpIndex = middleIndex + 1, inversePairCount = 0;
        while (leftHelpIndex <= middleIndex && rightHelpIndex <= rightIndex)
        {
            if (array[leftHelpIndex] > array[rightHelpIndex])
            {
                inversePairCount += middleIndex - leftHelpIndex + 1;
                array[orderedArrayIndex++] = array[rightHelpIndex++];
            }
            else
            {
                array[orderedArrayIndex++] = array[leftHelpIndex++];
            }
        }

        while (leftHelpIndex <= middleIndex)
        {
            array[orderedArrayIndex++] = array[leftHelpIndex++];
        }
        while (rightHelpIndex <= rightIndex)
        {
            array[orderedArrayIndex++] = array[rightHelpIndex++];
        }

        for (int i = 0; i < orderedArray.Length; i++)
        {
            array[leftIndex + i] = orderedArray[i];
        }

        return inversePairCount;
    }
}