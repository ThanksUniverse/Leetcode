public class Solution {
    public int MinimumOperations(int[] nums) {
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            var x = nums[i];
            if (x % 3 != 0) {
                count++;
            }
        }
        return count;
    }
}
