namespace Belly.Algorithm.Tests;

public class SmallSumaryTest
{
    [Fact]
    public void Calculate_ValidInput_ReturnSmallSumary()
    {
        //Arrage
        int[] array = { 1, 6, 2, 8, 3, 7, 4, 9, 5 };


        //Act
        SmallSumary smallSumary = new SmallSumary();
        int result = smallSumary.Process(array);

        //Assert
        Assert.Equal(73, result);
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