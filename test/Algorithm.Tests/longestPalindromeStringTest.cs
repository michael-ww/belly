namespace Algorithm.Tests;

public class longestPalindromeStringTest
{
    [Fact]
    public void Getlongest_ValidInput_ReturnString()
    {
        //Arrange
        string s = "abababa";

        //Act
        longestPalindromeString palindrome = new();
        string result = palindrome.Getlongest(s);

        //Assert
        Assert.Equal("abababa", result);
    }
}