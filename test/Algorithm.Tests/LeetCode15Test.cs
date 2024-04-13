namespace Belly.Algorithm.Tests
{
    public class LeetCode15Test
    {
        [Fact]
        public void ThreeSum_ValidInput_ReturnList()
        {
            //Arragne
            int[] nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums = new int[] { 0, 1, 1 };

            //Act
            LeetCode15 leetCode15 = new();
            IList<(int n1, int n2, int n3)> answer = leetCode15.ThreeSum(nums1);

            //Assert [[-1,-1,2],[-1,0,1]]
            Assert.Equal(-1, answer[0].n1);
            Assert.Equal(0, answer[0].n2);
            Assert.Equal(1, answer[0].n3);
        }

        [Fact]
        public void ThreeSumary_ValidInput_ReturnList()
        {
            //Arragne
            int[] nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] nums = new int[] { 0, 1, 1 };

            //Act
            LeetCode15 leetCode15 = new();
            IList<(int n1, int n2, int n3)> answer = leetCode15.ThreeSumary(nums1);

            //Assert [[-1,-1,2],[-1,0,1]]
            Assert.Equal(-1, answer[0].n1);
            Assert.Equal(0, answer[0].n2);
            Assert.Equal(1, answer[0].n3);
        }
    }
}