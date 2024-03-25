namespace Belly.Algorithm.Tests;

public class RomanToIntegerTest
{
    [Fact]
    public void Process_ValidInput_ReturnInteger()
    {
        //Arrange
        string input1 = "LVIII";
        string input2 = "MCMXCIV";

        //Act
        RomanToInteger roman = new();
        int answer1 = roman.Process(input1);
        int answer2 = roman.Process(input2);

        //Assert
        Assert.Equal(58, answer1);
        Assert.Equal(1994, answer2);
    }
}