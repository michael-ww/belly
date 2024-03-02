namespace Algorithm.Tests
{
    using System;

    public class SortedArrayMedianTest
    {
        [Fact]
        public void MergeSort_NullInput_ThrowException()
        {
            //Arrange
            int[]? array1 = null;
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();

            //Assert
            Assert.Throws<ArgumentException>(() => median.MergeSort(array1, array2));
        }

        [Fact]
        public void MergeSort_PartNullInput_ThrowException()
        {
            //Arrange
            int[] array1 = Array.Empty<int>();
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();

            //Assert
            Assert.Throws<ArgumentException>(() => median.MergeSort(array1, array2));
            Assert.Throws<ArgumentException>(() => median.MergeSort(array2, array1));
        }

        [Fact]
        public void MergeSort_ValidInput1_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3 };
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();
            double result1 = median.MergeSort(array1, array2);
            double result2 = median.MergeSort(array2, array1);

            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(2, result2);
        }

        [Fact]
        public void MergeSort_ValidInput2_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();
            double result1 = median.MergeSort(array1, array2);
            double result2 = median.MergeSort(array2, array1);

            //Assert
            Assert.Equal(2.5, result1);
            Assert.Equal(2.5, result2);
        }

        [Fact]
        public void MergeSort_ValidInput3_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.MergeSort(array1, array2);
            double result2 = median.MergeSort(array2, array1);

            //Assert
            Assert.Equal(8.5, result1);
            Assert.Equal(8.5, result2);
        }

        [Fact]
        public void MergeSort_ValidInput4_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.MergeSort(array1, array2);
            double result2 = median.MergeSort(array2, array1);

            //Assert
            Assert.Equal(8, result1);
            Assert.Equal(8, result2);
        }

        [Fact]
        public void Iterate_NullInput_ThrowException()
        {
            //Arrange
            int[] array1 = null;
            int[] array2 = null;

            //Act
            SortedArrayMedian median = new();

            //Assert
            Assert.Throws<ArgumentException>(() => median.Iterate(array1, array2));
        }

        [Fact]
        public void Iterate_PartNullInput_ThrowException()
        {
            //Arrange
            int[] array1 = new int[] { };
            int[] array2 = null;

            //Act
            SortedArrayMedian median = new();

            //Assert
            Assert.Throws<ArgumentException>(() => median.Iterate(array1, array2));
            Assert.Throws<ArgumentException>(() => median.Iterate(array2, array1));
        }

        [Fact]
        public void Iterate_ValidInput1_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = null;

            //Act
            SortedArrayMedian median = new();
            double result1 = median.Iterate(array1, array2);
            double result2 = median.Iterate(array2, array1);

            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(2, result2);
        }

        [Fact]
        public void Iterate_ValidInput2_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[] array2 = null;

            //Act
            SortedArrayMedian median = new();
            double result1 = median.Iterate(array1, array2);
            double result2 = median.Iterate(array2, array1);

            //Assert
            Assert.Equal(2.5, result1);
            Assert.Equal(2.5, result2);
        }

        [Fact]
        public void Iterate_ValidInput3_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.Iterate(array1, array2);
            double result2 = median.Iterate(array2, array1);

            //Assert
            Assert.Equal(8.5, result1);
            Assert.Equal(8.5, result2);
        }

        [Fact]
        public void Iterate_ValidInput4_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.Iterate(array1, array2);
            double result2 = median.Iterate(array2, array1);

            //Assert
            Assert.Equal(8, result1);
            Assert.Equal(8, result2);
        }

        [Fact]
        public void BinarySearch_NullInput_ThrowException()
        {
            //Arrange
            int[]? array1 = null;
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();

            //Assert
            Assert.Throws<ArgumentException>(() => median.BinarySearch(array1, array2));
        }

        [Fact]
        public void BinarySearch_PartNullInput_ThrowException()
        {
            //Arrange
            int[] array1 = Array.Empty<int>();
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();

            //Assert
            Assert.Throws<ArgumentException>(() => median.BinarySearch(array1, array2));
            Assert.Throws<ArgumentException>(() => median.BinarySearch(array2, array1));
        }

        [Fact]
        public void BinarySearch_ValidInput1_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3 };
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();
            double result1 = median.BinarySearch(array1, array2);
            double result2 = median.BinarySearch(array2, array1);

            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(2, result2);
        }

        [Fact]
        public void BinarySearch_ValidInput2_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[]? array2 = null;

            //Act
            SortedArrayMedian median = new();
            double result1 = median.BinarySearch(array1, array2);
            double result2 = median.BinarySearch(array2, array1);

            //Assert
            Assert.Equal(2.5, result1);
            Assert.Equal(2.5, result2);
        }

        [Fact]
        public void BinarySearch_ValidInput3_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.BinarySearch(array1, array2);
            double result2 = median.BinarySearch(array2, array1);

            //Assert
            Assert.Equal(8.5, result1);
            Assert.Equal(8.5, result2);
        }

        [Fact]
        public void BinarySearch_ValidInput4_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.BinarySearch(array1, array2);
            double result2 = median.BinarySearch(array2, array1);

            //Assert
            Assert.Equal(8, result1);
            Assert.Equal(8, result2);
        }

        [Fact]
        public void BinarySearch_ValidInput5_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.BinarySearch(array1, array2);
            double result2 = median.BinarySearch(array2, array1);

            //Assert
            Assert.Equal(9.5, result1);
            Assert.Equal(9.5, result2);
        }

        [Fact]
        public void BinarySearch_ValidInput6_ReturnMedian()
        {
            //Arrange
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] array2 = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            //Act
            SortedArrayMedian median = new();
            double result1 = median.BinarySearch(array1, array2);
            double result2 = median.BinarySearch(array2, array1);

            //Assert
            Assert.Equal(11, result1);
            Assert.Equal(11, result2);
        }
    }
}