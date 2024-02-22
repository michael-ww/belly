namespace Algorithm.Tests;

public class MaxAreaTest
{
    [Fact]
    public void Process_ValidInput_ReturnArea()
    {
        //Arrange
        int[] height1 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int[] height2 = new int[] { 1, 1 };

        //Act
        MaxArea area = new();
        int answer1 = area.Process(height1);
        int answer2 = area.Process(height2);

        //Assert
        Assert.Equal(49, answer1);
        Assert.Equal(1, answer2);
    }
}