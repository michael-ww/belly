namespace Algorithm.Tests
{
    public class RotatingArraySearchTest
    {
        [Fact]
        public void Process_ValidInput_ReturnIndex()
        {
            //Arrange
            int[] nums1 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int target1 = 2, target2 = 8;

            //Act
            RotatingArraySearch rotatingArraySearch = new();
            int index1 = rotatingArraySearch.Process(nums1, target1);
            int index2 = rotatingArraySearch.Process(nums1, target2);

            //Assert
            Assert.Equal(6, index1);
            Assert.Equal(-1, index2);
        }
    }
}