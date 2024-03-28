namespace Belly.Algorithm
{
    public class LeetCode76
    {
        public string MinWindow(string source, string target)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target) || source.Length < target.Length)
            {
                return string.Empty;
            }

            string answer = string.Empty;
            int leftIndex = 0, rightIndex = 0;
            while (rightIndex < source.Length)
            {

            }

            return answer;
        }
    }
}