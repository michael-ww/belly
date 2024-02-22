namespace Algorithm.Tests;

public class ThreeSumClosestTest
{
    [Fact]
    public void Process_ValidInput_ReturnClosestTarget()
    {
        //Arrange
        int[] nums1 = new int[] { -1, 2, 1, -4 };
        int[] nums2 = new int[] { 0, 0, 0 };
        int[] nums3 = new int[] { -1, 0, 1, 2, -1, -4 };
        int target = 1;

        //Act
        ThreeSumClosest threeSumClosest = new();
        int answer1 = threeSumClosest.Process(nums1, target);
        int answer2 = threeSumClosest.Process(nums2, target);
        int answer3 = threeSumClosest.Process(nums3, target);


        //Assert
        Assert.Equal(2, answer1);
        Assert.Equal(0, answer2);
        Assert.Equal(1, answer3);
    }
}