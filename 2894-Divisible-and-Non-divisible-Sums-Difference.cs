public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int num1 = 0;
        for (int i = 0; i < n; i++)
        {
            int x = i+1;
            if (x % m == 0)
                num1 += x;
        }
        int num2 = 0;
        for (int i = 0; i < n; i++)
        {
            int x = i+1;
            if (x % m != 0)
                num2 += x;
        }
        return num2-num1;
    }
}