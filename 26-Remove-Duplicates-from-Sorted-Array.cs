public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        for (var j = 0; j < nums.Length; j++)
        {
            if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i+1;
    }
}