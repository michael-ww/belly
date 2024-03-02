namespace Algorithm.Tests
{
    public class MergeSortingTest
    {
        [Fact]
        public void Process_ValidInput_ReturnOrderedArray()
        {
            //Arrange
            int[] nums = { 8, 4, 5, 7, 2, 5, 1, 0, 4, 5, 9 };

            //Act
            MergeSorting mergeSorting = new();
            mergeSorting.Process(nums);

            //Assert
            Assert.Equal(0, nums[0]);
            Assert.Equal(9, nums[^1]);
        }
    }
}