namespace Belly.Algorithm
{
    public class LeetCode11
    {
        public int MaxArea(int[] height)
        {
            ArgumentNullException.ThrowIfNull(height);
            if (height.Length < 2)
            {
                return 0;
            }
            int answer = 0, left = 0, right = height.Length - 1;
            while (left < right)
            {
                answer = height[left] > height[right] ? Math.Max(answer, (right - left) * height[right--]) : Math.Max(answer, (right - left) * height[left++]);
            }
            return answer;
        }
    }
}