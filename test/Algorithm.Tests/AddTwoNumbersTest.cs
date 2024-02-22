namespace Algorithm.Tests;

public class AddTwoNumbersTest
{
    [Fact]
    public void AddTwoNumbers_NullInput_ThrowException()
    {
        //Arrage
        AddTwoNumbers.ListNode l1 = null;
        AddTwoNumbers.ListNode l2 = null;

        //Act
        AddTwoNumbers addTwoNumbers = new AddTwoNumbers();

        //Assert
        Assert.Throws<ArgumentException>(() => addTwoNumbers.AddTwoNums(l1, l2));
    }

    [Fact]
    public void AddTwoNumbers_PartValidInput_ReturnHeadNode()
    {
        //Arrange
        AddTwoNumbers.ListNode l1 = new AddTwoNumbers.ListNode(1, null);
        AddTwoNumbers.ListNode l2 = null;

        //Act
        AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
        AddTwoNumbers.ListNode result = addTwoNumbers.AddTwoNums(l1, l2);

        //Assert
        Assert.Equal(l1.Value, result.Value);
    }

    [Fact]
    public void AddTowNumbers_ValidInput_ReturnHeadNode()
    {
        //Arrange
        AddTwoNumbers.ListNode l11 = new AddTwoNumbers.ListNode(6, null);
        AddTwoNumbers.ListNode l1 = new AddTwoNumbers.ListNode(9, l11);
        AddTwoNumbers.ListNode l22 = new AddTwoNumbers.ListNode(5, null);
        AddTwoNumbers.ListNode l2 = new AddTwoNumbers.ListNode(2, l22);

        //Act
        AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
        AddTwoNumbers.ListNode result = addTwoNumbers.AddTwoNums(l1, l2);

        //Assert
        Assert.Equal(1, result.Value);
        Assert.Equal(2, result.Next.Value);
    }

}