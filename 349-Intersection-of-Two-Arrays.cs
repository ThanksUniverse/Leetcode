public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> hash = new();
        for(int i = 0; i < nums1.Length;i++)
        {
            for (int j = 0; j < nums2.Length;j++)
            {
                if (nums1[i] == nums2[j])
                    hash.Add(nums1[i]);
            }
        }
        int[] ans = new int[hash.Count];
        int index = 0;
        foreach(var k in hash)
        {
            ans[index++]=k;
        }
        return ans;
    }
}