public class Solution {
    public int MaxArea(int[] height) {
        int highestWater = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            int heightLeft = height[left];
            int heightRight = height[right];
            int calc = Math.Min(heightLeft, heightRight) * (right - left);
            highestWater = Math.Max(highestWater,calc);
            if (heightLeft > heightRight)
                right--;
            else
                left++;
        }
        return highestWater;
    }
}