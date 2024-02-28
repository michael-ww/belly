namespace Algorithm.Tests
{
    public class OddTimeNumberTes
    {
        [Fact]
        public void Process_ValidInput_ReturnNumber()
        {
            //Arrange
            int[] nums = new int[] { 2, 4, 6, 8, 1, 0, 2, 2, 2, 8, 4, 1, 0 };

            //Act
            OddTimeNumber oddTimesNumber = new();
            int answer = oddTimesNumber.Process(nums);

            //Assert
            Assert.Equal(6, answer);
        }
    }
}