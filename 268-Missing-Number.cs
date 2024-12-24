public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> hash = new();
        int highestNum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!hash.Contains(nums[i]))
                hash.Add(nums[i]);
            highestNum = Math.Max(highestNum, nums[i]);
        }
        for (int i = 0; i < highestNum; i++)
        {
            if (!hash.Contains(i))
                return i;
        }
        if (!hash.Contains(highestNum + 1))
            return highestNum+1;
        return 0;
    }
}