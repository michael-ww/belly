namespace Algorithm.Tests;

public class RemoveElementTest
{
    [Fact]
    public void Process_ValidInput_ReturnLength()
    {
        //Arrange
        int[] nums1 = new int[] { 3, 2, 2, 3 };
        int target1 = 3;
        int[] nums2 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        int target2 = 2;
        int[] nums3 = new int[] { 2, 2, 2, 2 };
        int target3 = 2;

        //Act
        RemoveElement removeElement = new();
        int length1 = removeElement.Process(nums1, target1);
        int length2 = removeElement.Process(nums2, target2);
        int length3 = removeElement.Process(nums3, target3);

        //Assert
        Assert.Equal(2, length1);
        Assert.Equal(2, nums1[0]);
        Assert.Equal(2, nums1[1]);
        Assert.Equal(5, length2);
        Assert.Equal(0, nums2[0]);
        Assert.Equal(1, nums2[1]);
        Assert.Equal(3, nums2[2]);
        Assert.Equal(0, nums2[3]);
        Assert.Equal(4, nums2[4]);
        Assert.Equal(0, length3);
    }
}