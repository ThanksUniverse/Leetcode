public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> missedElement=new List<int>(){};
        bool[] check = new bool[nums.Length + 1];
        for(int i=0;i<nums.Length;i++)
            check[nums[i]] = true;
        for(int i=1;i<=nums.Length;i++)
            if(!check[i])
                missedElement.Add(i);
        return missedElement;
    }
}