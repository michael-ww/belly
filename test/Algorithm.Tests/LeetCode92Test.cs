namespace Belly.Algorithm.Tests
{
    public class LeetCode92Test
    {
        [Fact]
        public void ReverseBetween1_ValidInput1_ReturnHead()
        {
            //Arrange
            ListNode tail = new(5, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode92 leetCode92 = new();
            ListNode answer = leetCode92.ReverseBetween1(head, 2, 4);


            //Assert
            Assert.Equal(4, answer.Next.Value);
        }

        [Fact]
        public void ReverseBetween1_ValidInput2_ReturnHead()
        {
            //Arrange
            ListNode tail = new(5, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode92 leetCode92 = new();
            ListNode answer = leetCode92.ReverseBetween1(head, 1, 4);


            //Assert
            Assert.Equal(4, answer.Value);
        }

        [Fact]
        public void ReverseBetween1_ValidInput3_ReturnHead()
        {
            //Arrange
            ListNode tail = new(5, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode92 leetCode92 = new();
            ListNode answer = leetCode92.ReverseBetween1(head, 2, 5);


            //Assert
            Assert.Equal(5, answer.Next.Value);
        }

        [Fact]
        public void ReverseBetween2_ValidInput1_ReturnHead()
        {
            //Arrange
            ListNode tail = new(5, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode92 leetCode92 = new();
            ListNode answer = leetCode92.ReverseBetween2(head, 2, 4);


            //Assert
            Assert.Equal(4, answer.Next.Value);
        }

        [Fact]
        public void ReverseBetween2_ValidInput2_ReturnHead()
        {
            //Arrange
            ListNode tail = new(5, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode92 leetCode92 = new();
            ListNode answer = leetCode92.ReverseBetween2(head, 1, 4);


            //Assert
            Assert.Equal(4, answer.Value);
        }

        [Fact]
        public void ReverseBetween2_ValidInput3_ReturnHead()
        {
            //Arrange
            ListNode tail = new(5, null);
            ListNode fouth = new(4, tail);
            ListNode third = new(3, fouth);
            ListNode second = new(2, third);
            ListNode head = new(1, second);

            //Act
            LeetCode92 leetCode92 = new();
            ListNode answer = leetCode92.ReverseBetween2(head, 2, 5);


            //Assert
            Assert.Equal(5, answer.Next.Value);
        }
    }
}