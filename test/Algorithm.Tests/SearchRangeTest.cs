namespace Algorithm.Tests
{
    public class SearchRangeTest
    {
        [Fact]
        public void Process_ValidInput_ReturnRange()
        {
            //Arrange
            int[] nums1 = new int[] { 5, 7, 7, 8, 8, 10 };
            int[] nums2 = Array.Empty<int>();
            int target1 = 8;
            int target2 = 6;

            //Act
            SearchRange searchRange = new();
            Tuple<int, int> tuple1 = searchRange.Process(nums1, target1);
            Tuple<int, int> tuple2 = searchRange.Process(nums1, target2);
            Tuple<int, int> tuple3 = searchRange.Process(nums2, target1);

            //Assert
            Assert.Equal(Tuple.Create(3, 4), tuple1);
            Assert.Equal(Tuple.Create(-1, -1), tuple2);
            Assert.Equal(Tuple.Create(-1, -1), tuple3);
        }
    }
}