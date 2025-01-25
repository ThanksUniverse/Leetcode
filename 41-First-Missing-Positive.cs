public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> hash = new();
        Array.Sort(nums);
        foreach(var n in nums)
            if (!hash.Contains(n) && n > 0)
                hash.Add(n);
        int last = nums[nums.Length -1];
        if (last < 0) return 1;
        int target = hash.FirstOrDefault(2);
        if (target > 1) return 1;
        while (hash.Contains(target) || target <= 0)
        {
            target++;
        }
        return target;
    }
}