namespace Belly.Algorithm.Tests
{
    public class TwoOddTimeNumberTest
    {
        [Fact]
        public void Process_ValidInput_ReturnNumbers()
        {
            //Arrange
            int[] nums = new int[] { 2, 2, 9, 9, 4, 4, 1, 1, 7, 8 };

            //Act
            TwoOddTimeNumber twoOddTimeNumber = new();
            (int odd1, int odd2) = twoOddTimeNumber.Process(nums);

            //Assert
            Assert.Equal(7, odd1);
            Assert.Equal(8, odd2);
        }
    }
}