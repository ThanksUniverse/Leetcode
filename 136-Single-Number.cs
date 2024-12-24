public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, bool> hash = new(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (!hash.ContainsKey(num))
                hash.Add(num, false);
            else
                hash[num] = true;
        }
        foreach(var k in hash.Keys)
        {
            if (!hash[k])
                return k;
        }
        return 0;
    }
}