namespace Algorithm.Tests;

public class SortingTest
{

    [Fact]
    public void SelectionSorting_ValidInput_ReturnOrderedArray()
    {
        //Arrange
        int[] array = { 7, 6, 5, 4, 3, 2, 1 };

        //Act
        Sorting sort = new Sorting();
        sort.SelectionSort(array);

        //Assert
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
        Assert.Equal(3, array[2]);
        Assert.Equal(4, array[3]);
        Assert.Equal(5, array[4]);
        Assert.Equal(6, array[5]);
        Assert.Equal(7, array[6]);

    }

    [Fact]
    public void InsertionSorting_ValidInput_ReturnOrderedArray()
    {
        //Arrange
        int[] array = { 7, 6, 5, 4, 3, 2, 1 };

        //Act
        Sorting sort = new();
        sort.InsertionSort(array);

        //Assert
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
        Assert.Equal(3, array[2]);
        Assert.Equal(4, array[3]);
        Assert.Equal(5, array[4]);
        Assert.Equal(6, array[5]);
        Assert.Equal(7, array[6]);
    }

    [Fact]
    public void BubbleSorting_ValidInput_ReturnOrderedArray()
    {
        //Arrange
        int[] array = { 7, 6, 5, 4, 3, 2, 1 };

        //Act
        Sorting sort = new();
        sort.BubbleSort(array);

        //Assert
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
        Assert.Equal(3, array[2]);
        Assert.Equal(4, array[3]);
        Assert.Equal(5, array[4]);
        Assert.Equal(6, array[5]);
        Assert.Equal(7, array[6]);
    }

    [Fact]
    public void MergeSort_ValidInput_ReturnOrderedArray()
    {
        //Arrange
        int[] array = { 7, 6, 5, 4, 3, 2, 1 };

        //Act
        Sorting sort = new();
        sort.MergeSort(array);

        //Assert
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
        Assert.Equal(3, array[2]);
        Assert.Equal(4, array[3]);
        Assert.Equal(5, array[4]);
        Assert.Equal(6, array[5]);
        Assert.Equal(7, array[6]);
    }

    [Fact]
    public void QuickSort_ValidInput_ReturnOrderedArray()
    {
        //Arrange
        int[] array = { 7, 6, 5, 4, 3, 2, 1 };

        //Act
        Sorting sort = new();
        sort.QuickSort(array);

        //Assert
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
        Assert.Equal(3, array[2]);
        Assert.Equal(4, array[3]);
        Assert.Equal(5, array[4]);
        Assert.Equal(6, array[5]);
        Assert.Equal(7, array[6]);
    }

    [Fact]
    public void HeapSort_ValidInput_ReturnOrderedArray()
    {
        //Arrange
        int[] array = { 2, 8, 5, 3, 7, 9, 1, 6, 4 };

        //Act
        Sorting sort = new();
        sort.HeapSort(array);

        //Assert
        Assert.Equal(1, array[0]);
        Assert.Equal(2, array[1]);
        Assert.Equal(3, array[2]);
        Assert.Equal(4, array[3]);
        Assert.Equal(5, array[4]);
        Assert.Equal(6, array[5]);
        Assert.Equal(7, array[6]);
        Assert.Equal(8, array[7]);
        Assert.Equal(9, array[8]);
    }
}