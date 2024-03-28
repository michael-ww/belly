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
            string answer1 = leetCode3.LongestDistinctSubstring(s1);
            string answer2 = leetCode3.LongestDistinctSubstring(s2);
            string answer3 = leetCode3.LongestDistinctSubstring(s3);

            // Then
            Assert.Equal("abc", answer1);
            Assert.Equal("b", answer2);
            Assert.Equal("wke", answer3);
        }
    }
}