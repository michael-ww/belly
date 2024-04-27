namespace Belly.Algorithm.Tests
{
    public class RadixSortTest
    {
        [Fact]
        public void Process_ValidInput_Succeed()
        {
            //given
            int[] nums = { 6, 3, -2, 8, 22, 1, -9 };

            //when
            new RadixSort().Process(nums);

            //then
            Assert.Equal(-9, nums[0]);
            Assert.Equal(22, nums[^1]);
        }

        [Fact]
        public void Process_ValidInputs_Succeed()
        {
            for (int i = 0; i < 10; i++)
            {
                int[] nums = Utility.GenerateArray(i + 1, 1000, false, true);
                int[] copy = new int[nums.Length];
                Array.Copy(nums, copy, nums.Length);
                new RadixSort().Process(nums);
                Array.Sort(copy);
                Assert.Equal(nums, copy);
            }
        }
    }
}