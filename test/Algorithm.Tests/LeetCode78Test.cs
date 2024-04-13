namespace Belly.Algorithm.Tests
{
    public class LeetCode78Test
    {
        [Fact]
        public void Subsets_ValidInput_ReturnSubsets()
        {
            // Given
            int[] nums = { 1, 2, 3 };

            // When
            List<List<int>> answer = new LeetCode78().Subsets(nums);

            // Then
            Assert.Equal(8, answer.Count);
            Assert.Equal(nums, answer[7]);
        }
    }
}