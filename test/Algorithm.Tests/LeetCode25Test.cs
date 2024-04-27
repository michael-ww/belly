namespace Belly.Algorithm.Tests
{
    public class LeetCode25Test
    {
        [Fact]
        public void ReverseKGroup_ValidInput_ReturnHead()
        {
            // Given
            ListNode ln5 = new(42);
            ListNode ln4 = new(10, ln5);
            ListNode ln3 = new(7, ln4);
            ListNode ln2 = new(3, ln3);
            ListNode ln1 = new(-1, ln2);

            // When
            ListNode answer = new LeetCode25().ReverseKGroup(ln1, 2);

            // Then
            Assert.Equal(3, answer.Value);
        }
    }
}