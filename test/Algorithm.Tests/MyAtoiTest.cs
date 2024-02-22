namespace Algorithm.Tests;

public class MyAtoiTest
{
    [Fact]
    public void Process_ValidInput_ReturnInt()
    {
        //Arrange
        string s1 = "45632 Hello World";
        string s2 = "__-45632";
        string s3 = "45632";
        string s4 = "  &45632  ";
        //Act

        MyAtoi myAtoi = new();
        int answer1 = myAtoi.Process(s1);
        int answer2 = myAtoi.Process(s2);
        int answer3 = myAtoi.Process(s3);
        int answer4 = myAtoi.Process(s4);


        //Assert
        Assert.Equal(45632, answer1);
        Assert.Equal(-45632, answer2);
        Assert.Equal(45632, answer3);
        Assert.Equal(45632, answer4);
    }
}