namespace Algorithm.Tests;

public class RemoveDuplicatesTest
{
    [Fact]
    public void Process_ValidInput_ReturnLength()
    {
        //Arrange
        int[] nums1 = new int[] { 1, 1, 2 };
        int[] nums2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        //Act
        RemoveDuplicates removeDuplicates = new();
        int length1 = removeDuplicates.Process(nums1);
        int length2 = removeDuplicates.Process(nums2);

        //Assert
        Assert.Equal(2, length1);
        Assert.Equal(5, length2);
    }
}