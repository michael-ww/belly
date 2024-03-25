namespace Belly.Algorithm.Tests
{
    public class SearchInsertTest
    {
        [Fact]
        public void Process_ValidInput_ReturnIndex()
        {
            //Arrange
            int[] nums1 = new int[] { 1, 3, 5, 6 };
            int[] nums2 = new int[] { 1, 3, 5, 5, 5, 5, 6, 7, 9, 13 };
            int target1 = 5, target2 = 2, target3 = 7, target4 = 5;

            //Act
            SearchInsert searchInsert = new();
            int answer1 = searchInsert.Process(nums1, target1);
            int answer2 = searchInsert.Process(nums1, target2);
            int answer3 = searchInsert.Process(nums1, target3);
            int answer4 = searchInsert.Process(nums2, target4);

            //Assert
            Assert.Equal(3, answer1);
            Assert.Equal(1, answer2);
            Assert.Equal(4, answer3);
            Assert.Equal(6, answer4);
        }
    }
}