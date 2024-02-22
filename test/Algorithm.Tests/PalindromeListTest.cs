namespace Algorithm.Tests;

public class PalindromeListTest
{
    [Fact]
    public void IsPalindrome1_ValidInput1_ReturnBoolean()
    {
        //Arrange
        ListNode tail = new(1, null);
        ListNode fouth = new(2, tail);
        ListNode third = new(3, fouth);
        ListNode second = new(2, third);
        ListNode head = new(1, second);

        //Act
        PalindromeList palindrome = new();
        bool answer = palindrome.IsPalindrome1(head);

        //Assert
        Assert.True(answer);
    }

    [Fact]
    public void IsPalindrome1_ValidInput2_ReturnBoolean()
    {
        //Arrange
        ListNode tail = new(1, null);
        ListNode fouth = new(2, tail);
        ListNode second = new(2, fouth);
        ListNode head = new(1, second);

        //Act
        PalindromeList palindrome = new();
        bool answer = palindrome.IsPalindrome1(head);

        //Assert
        Assert.True(answer);
    }
}