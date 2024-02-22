namespace Algorithm.Tests;

public class KInversePairsTest
{
    [Fact]
    public void Calculate_ValidInput_ReturnReversedPairCount()
    {
        //Arrange
        int[] array = { 4, 9, 2, 7, 5, 3, 8, 1, 6 };

        //Act
        KInversePairs inversePairs = new();
        int inversePairCount = inversePairs.Calculate(array);

        //Assert
        Assert.Equal(19, inversePairCount);
        Assert.Equal(1, array[8]);
        Assert.Equal(2, array[7]);
        Assert.Equal(3, array[6]);
        Assert.Equal(4, array[5]);
        Assert.Equal(5, array[4]);
        Assert.Equal(6, array[3]);
        Assert.Equal(7, array[2]);
        Assert.Equal(8, array[1]);
        Assert.Equal(9, array[0]);
    }
}