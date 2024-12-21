public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> h = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int c = target - nums[i];
            if (!h.ContainsKey(nums[i]))
                h.Add(nums[i], i);
            if (h.ContainsKey(c) && i != h[c])
                return new int[2] {h[c], i};
        }
        return new int[0];
    }
}
