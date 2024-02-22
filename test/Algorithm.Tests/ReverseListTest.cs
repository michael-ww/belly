namespace Algorithm.Tests;

public class ReverseListTest
{
    [Fact]
    public void Process_ValidInput_ReturnHead()
    {
        //Arrange
        ListNode tail = new(5, null);
        ListNode fouth = new(4, tail);
        ListNode third = new(3, fouth);
        ListNode second = new(2, third);
        ListNode head = new(1, second);


        //Act
        ReverseList reverse = new();
        ListNode answer = reverse.Process(head);

        //Assert
        Assert.Equal(5, answer.Value);
        Assert.Equal(4, answer.Next.Value);
    }

    [Fact]
    public void ProcessBetween_ValidInput_ReturnHead()
    {
        //Arrange
        ListNode tail = new(5, null);
        ListNode fouth = new(4, tail);
        ListNode third = new(3, fouth);
        ListNode second = new(2, third);
        ListNode head = new(1, second);


        //Act
        ReverseList reverse = new();
        ListNode answer = reverse.Process(head, 2, 3);

        //Assert
        Assert.Equal(2, answer.Next.Next.Value);
        Assert.Equal(3, answer.Next.Value);
    }
}