namespace Algorithm.Tests
{
    using System;

    public class TwoSumTest
    {
        [Fact]
        public void TwoSumFor_NullInput_ThrowException()
        {
            //Arrage
            int[]? nums = default;
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();

            //Assert
            Assert.Throws<ArgumentException>(() => twoSum.TwoSumFor(nums, target));
        }

        [Fact]
        public void TwoSumFor_InvalidInput_ThrowException()
        {
            //Arrage
            int[] nums = new int[] { 2 };
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();

            //Assert
            Assert.Throws<ArgumentException>(() => twoSum.TwoSumFor(nums, target));
        }

        [Fact]
        public void TwoSumFor_ValidInput_ReturnInt32Array()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.TwoSumFor(nums, target);

            //Assert
            Assert.Collection(result, e => Assert.Equal(1, result[0]), e => Assert.Equal(2, result[1]));
        }

        [Fact]
        public void TwoSumFor_ValidInput_ReturnNull()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 11;

            //Act
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.TwoSumFor(nums, target);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void TwoSumCache_NullInput_ThrowException()
        {
            //Arrage
            int[]? nums = default;
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();

            //Assert
            Assert.Throws<ArgumentException>(() => twoSum.TwoSumCache(nums, target));
        }

        [Fact]
        public void TwoSumCache_InvalidInput_ThrowException()
        {
            //Arrage
            int[] nums = new int[] { 2 };
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();

            //Assert
            Assert.Throws<ArgumentException>(() => twoSum.TwoSumCache(nums, target));
        }

        [Fact]
        public void TwoSumCache_ValidInput_ReturnInt32Array()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.TwoSumCache(nums, target);

            //Assert
            Assert.Collection(result, e => Assert.Equal(1, result[0]), e => Assert.Equal(2, result[1]));
        }

        [Fact]
        public void TwoSumCache_ValidInput_ReturnNull()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 11;

            //Act
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.TwoSumCache(nums, target);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void TwoSumForSortedArray_NullInput_ThrowException()
        {
            //Arrage
            int[]? nums = default;
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();

            //Assert
            Assert.Throws<ArgumentException>(() => twoSum.TwoSumForSortedArray(nums, target));
        }

        [Fact]
        public void TwoSumForSortedArray_InvalidInput_ThrowException()
        {
            //Arrage
            int[] nums = new int[] { 2 };
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();

            //Assert
            Assert.Throws<ArgumentException>(() => twoSum.TwoSumForSortedArray(nums, target));
        }

        [Fact]
        public void TwoSumForSortedArray_ValidInput_ReturnInt32Array()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 9;

            //Act
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.TwoSumForSortedArray(nums, target);

            //Assert
            Assert.Collection(result, e => Assert.Equal(1, result[0]), e => Assert.Equal(2, result[1]));
        }

        [Fact]
        public void TwoSumForSortedArray_ValidInput_ReturnNull()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 11;

            //Act
            TwoSum twoSum = new TwoSum();
            int[] result = twoSum.TwoSumFor(nums, target);

            //Assert
            Assert.Null(result);
        }
    }
}