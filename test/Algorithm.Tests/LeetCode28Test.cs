namespace Belly.Algorithm.Tests
{
    public class LeetCode28Test
    {
        [Fact]
        public void StrStr_ValidInput_ReturnIndex()
        {
            // Given
            string haystack1 = "sadbutsad", needle1 = "sad";
            string haystack2 = "leetcode", needle2 = "leeto";

            // When
            int answer1 = new LeetCode28().StrStr(haystack1, needle1);
            int answer2 = new LeetCode28().StrStr(haystack2, needle2);

            // Then
            Assert.Equal(0, answer1);
            Assert.Equal(-1, answer2);
        }
    }
}