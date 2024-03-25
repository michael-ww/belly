namespace Belly.Algorithm.Tests
{
    using System;
    using System.Collections.Generic;

    public class ThreeSumTest
    {
        [Fact]
        public void Process_ValidInput_ReturnArray()
        {
            //Arrange
            int[] nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums2 = new int[] { 0, 1, 1 };
            int[] nums3 = new int[] { 0, 0, 0 };

            //Act
            ThreeSum threeSum = new();
            IList<Tuple<int, int, int>> answer1 = threeSum.Process(nums1);
            IList<Tuple<int, int, int>> answer2 = threeSum.Process(nums2);
            IList<Tuple<int, int, int>> answer3 = threeSum.Process(nums3);

            //Assert
            Assert.Equal(2, answer1.Count);
            Assert.Contains(Tuple.Create(-1, -1, 2), answer1);
            Assert.Contains(Tuple.Create(-1, 0, 1), answer1);
            Assert.Empty(answer2);
            Assert.Equal(1, answer3.Count);
            Assert.Contains(Tuple.Create(0, 0, 0), answer3);
        }
    }
}