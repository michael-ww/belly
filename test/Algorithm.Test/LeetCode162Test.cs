namespace Belly.Algorithm.Test
{
    public class LeetCode162Test
    {
        [Fact]
        public void FindPeakElement_ValidInput_ReturnMaximum()
        {
            // Given
            int[] nums1 = [1, 2, 3, 1], nums2 = [1, 2, 1, 3, 5, 6, 4];

            // When
            LeetCode162 leetCode162 = new();
            int answer1 = leetCode162.FindPeakElement(nums1);
            int answer2 = leetCode162.FindPeakElement(nums2);

            // Then
            Assert.Equal(2, answer1);
            Assert.Equal(5, answer2);
        }
    }
}