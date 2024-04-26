namespace Belly.Algorithm
{
    public class PaperFolding
    {
        public string PrintCrease(int n)
        {
            if (n <= 0)
            {
                return string.Empty;
            }
            return this.PrintCrease(1, n, true).Trim();
        }

        public string PrintCrease(int currentDepth, int maxDepth, bool isDown)
        {
            if (currentDepth > maxDepth)
            {
                return string.Empty;
            }
            StringBuilder sb = new();
            sb.Append(this.PrintCrease(currentDepth + 1, maxDepth, true));
            sb.Append(isDown ? " down" : " up");
            sb.Append(this.PrintCrease(currentDepth + 1, maxDepth, false));
            return sb.ToString();
        }
    }
}