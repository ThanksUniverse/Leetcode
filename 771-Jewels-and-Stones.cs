public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int x = 0;
        foreach(var c in stones)
        {
            if (jewels.Contains(c))
                x++;
        }
        return x;
    }
}