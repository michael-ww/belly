namespace Algorithm.Tests
{
    using System;
    using System.Collections.Generic;

    public class FourSumTest
    {
        [Fact]
        public void Process_ValidInput_ReturnAnswer()
        {
            //Arrange
            int[] nums1 = new int[] { 1, 0, -1, 0, -2, 2 };
            int target1 = 0;
            int[] nums2 = new int[] { 2, 2, 2, 2, 2 };
            int target2 = 8;

            //Act
            FourSum fourSum = new();
            IList<Tuple<int, int, int, int>> answer1 = fourSum.Process(nums1, target1);
            IList<Tuple<int, int, int, int>> answer2 = fourSum.Process(nums2, target2);

            //Assert
            Assert.Equal(3, answer1.Count);
            Assert.Contains(Tuple.Create(-2, -1, 1, 2), answer1);
            Assert.Contains(Tuple.Create(-2, 0, 0, 2), answer1);
            Assert.Contains(Tuple.Create(-1, 0, 0, 1), answer1);
            Assert.Equal(1, answer2.Count);
            Assert.Contains(Tuple.Create(2, 2, 2, 2), answer2);
        }
    }
}