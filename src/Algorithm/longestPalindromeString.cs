namespace Algorithm;

public class longestPalindromeString
{
    public string Getlongest(string s)
    {
        if (s == null || s.Length <= 1)
        {
            return s;
        }

        int startIndex = 0, endIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int length1 = this.ExpandAroundCenter(s, i, i);
            int length2 = this.ExpandAroundCenter(s, i, i + 1);
            int length = Math.Max(length1, length2);
            if (length > endIndex - startIndex)
            {
                startIndex = i - ((length - 1) / 2);
                endIndex = i + (length / 2);
            }
        }

        return s.Substring(startIndex, endIndex - startIndex + 1);
    }

    private int ExpandAroundCenter(string s, int leftIndex, int rightIndex)
    {
        while (leftIndex >= 0 && rightIndex < s.Length && s.ElementAt(leftIndex) == s.ElementAt(rightIndex))
        {
            leftIndex--;
            rightIndex++;
        }

        return rightIndex - leftIndex - 1;
    }
}