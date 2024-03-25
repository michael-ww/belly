namespace Belly.Algorithm.Tests
{
    public class LeetCode3Test
    {
        [Fact]
        public void LengthOfLongestSubstring_ValidInput_ReturnLongestLength()
        {
            // Given
            string s1 = "abcabcbb";
            string s2 = "bbbbb";
            string s3 = "pwwkew";

            // When
            LeetCode3 leetCode3 = new();
            int length1 = leetCode3.LengthOfLongestSubstring(s1);
            int length2 = leetCode3.LengthOfLongestSubstring(s2);
            int length3 = leetCode3.LengthOfLongestSubstring(s3);

            // Then
            Assert.Equal(3, length1);
            Assert.Equal(1, length2);
            Assert.Equal(3, length3);
        }
    }
}