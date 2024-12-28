public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        for (int i=0;i<nums.Length;i++)
            answer[i]=1;
        int prefix = 1;
        for (int i=0;i<nums.Length;i++)
        {
            answer[i]=prefix;
            prefix*=nums[i];
        }
        int postfix = 1;
        for(int i=nums.Length-1;i>=0;i--)
        {
            answer[i]*=postfix;
            postfix*=nums[i];
        }
        return answer;
    }
}