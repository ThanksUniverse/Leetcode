public class Solution 
{
    public bool Check(int[] nums) 
    {
        int g = 0;
        int l = nums.Length;
        for (int i = 0; i < l; i++)
        {
            int p = i + 1 >= l ? 0 : i + 1;
            int n = nums[p];
            int v = nums[i];
            if (v > n)
                g++;
            if (g > 1) return false;
        }
        return true;
    }
}