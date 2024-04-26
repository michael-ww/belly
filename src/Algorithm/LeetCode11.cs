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
            int left = 0, right = height.Length - 1, area = 0;
            while (left < right)
            {
                area = height[left] > height[right] ? Math.Max(area, (right - left) * height[right--]) : Math.Max(area, (right - left) * height[left++]);
            }
            return area;
        }
    }
}