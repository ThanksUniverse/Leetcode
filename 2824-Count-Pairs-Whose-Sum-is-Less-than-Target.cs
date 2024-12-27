public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        nums = nums.OrderBy(x => x).ToList();
        int left = 0, right = nums.Count -1, count = 0;
        while (left < right)
        {
            int valLeft = nums[left];
            int valRight = nums[right];
            int calc = valLeft + valRight;
            if (calc < target)
            {
                count+= right - left;
                left++;
            }
            else
                right--;
        }
        return count;
    }
}