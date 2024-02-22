namespace Algorithm.Tests
{
    public class NextPermutationTest
    {
        [Fact]
        public void Process_ValidInput_ReturnNext()
        {
            //Arrange
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            int[] nums2 = new int[] { 1, 2, 3, 5, 4 };
            int[] nums3 = new int[] { 1, 2, 4, 5, 3 };
            int[] nums4 = new int[] { 5, 4, 3, 2, 1 };

            //Act
            NextPermutation nextPermutation = new();
            nextPermutation.Process(nums1);
            nextPermutation.Process(nums2);
            nextPermutation.Process(nums3);
            nextPermutation.Process(nums4);

            //Assert
            Assert.Equal(new int[] { 1, 2, 3, 5, 4 }, nums1);
            Assert.Equal(new int[] { 1, 2, 4, 3, 5 }, nums2);
            Assert.Equal(new int[] { 1, 2, 5, 3, 4 }, nums3);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, nums4);
        }
    }
}