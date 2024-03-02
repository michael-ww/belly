namespace Algorithm.Tests
{
    using System;

    [Fact]
    public void AddTwoNumbers_NullInput_ThrowException()
    {
        //Arrage
        ListNode l1 = null;
        ListNode l2 = null;

        //Act
        AddTwoNumbers addTwoNumbers = new();

        //Assert
        Assert.Throws<ArgumentException>(() => addTwoNumbers.AddTwoNums(l1, l2));
    }

    public class AddTwoNumbersTest
    {
        //Arrange
        ListNode l1 = new(1, null);
        ListNode l2 = null;

        //Act
        AddTwoNumbers addTwoNumbers = new();
        ListNode result = addTwoNumbers.AddTwoNums(l1, l2);

        //Assert
        Assert.Equal(l1.Value, result.Value);
    }

    [Fact]
    public void AddTowNumbers_ValidInput_ReturnHeadNode()
    {
        //Arrange
        ListNode l11 = new(6, null);
        ListNode l1 = new(9, l11);
        ListNode l22 = new(5, null);
        ListNode l2 = new(2, l22);

        //Act
        AddTwoNumbers addTwoNumbers = new();
        ListNode result = addTwoNumbers.AddTwoNums(l1, l2);

        //Assert
        Assert.Equal(1, result.Value);
        Assert.Equal(2, result.Next.Value);
    }

}