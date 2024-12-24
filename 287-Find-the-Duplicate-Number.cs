public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> hash = new();
        foreach(var x in nums)
            if (!hash.Add(x)) return x;
        return 0;
    }
}