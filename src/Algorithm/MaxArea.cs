namespace Algorithm;

public class MaxArea
{
    public int Process(int[] height)
    {
        if (height == null || height.Length < 2)
        {
            return 0;
        }

        int leftIndex = 0, rightIndex = height.Length - 1, maxArea = 0;
        while (leftIndex < rightIndex)
        {
            int area = Math.Min(height[leftIndex], height[rightIndex]) * (rightIndex - leftIndex);
            if (area > maxArea)
            {
                maxArea = area;
            }
            if (height[leftIndex] > height[rightIndex])
            {
                rightIndex--;
            }
            else
            {
                leftIndex++;
            }
        }

        return maxArea;
    }
}