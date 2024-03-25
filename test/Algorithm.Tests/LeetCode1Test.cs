namespace Belly.Algorithm.Tests
{
    using System;

    public class LeetCode1Test
    {
        [Fact]
        public void TwoSum1_NullInput_ReturnInvalidIndexes()
        {
            //Arrage
            int[] nums = default;
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum1_InvalidInput_ReturnInvalidIndexes()
        {
            //Arrage
            int[] nums = new int[] { 2 };
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum1_ValidInput_ReturnValidIndexes()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(1, leftIndex);
            Assert.Equal(2, rightIndex);
        }

        [Fact]
        public void TwoSum1_ValidInput_ReturnInValidIndexes()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 11;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum2_NullInput_ReturnInvalidIndexes()
        {
            //Arrage
            int[] nums = default;
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum2_InvalidInput_ReturnInvalidIndexes()
        {
            //Arrage
            int[] nums = new int[] { 2 };
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum2_ValidInput_ReturnValidIndexes()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum2(nums, target);

            //Assert
            Assert.Equal(1, leftIndex);
            Assert.Equal(2, rightIndex);
        }

        [Fact]
        public void TwoSum2_ValidInput_ReturnInvalidIndexes()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 11;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum2(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum3_NullInput_ReturnInvalidIndexes()
        {
            //Arrage
            int[] nums = default;
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum3_InvalidInput_ReturnInvalidIndexes()
        {
            //Arrage
            int[] nums = new int[] { 2 };
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TwoSum1(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }

        [Fact]
        public void TwoSum3_ValidInput_ReturnValidIndexes()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 9;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TowSum3(nums, target);

            //Assert
            Assert.Equal(1, leftIndex);
            Assert.Equal(2, rightIndex);
        }

        [Fact]
        public void TwoSum3_ValidInput_ReturnInvalidIndexes()
        {
            //Arrange
            int[] nums = new int[] { 1, 3, 6, 9, 22 };
            int target = 11;

            //Act
            LeetCode1 leetCode1 = new();
            (int leftIndex, int rightIndex) = leetCode1.TowSum3(nums, target);

            //Assert
            Assert.Equal(-1, leftIndex);
            Assert.Equal(-1, rightIndex);
        }
    }
}