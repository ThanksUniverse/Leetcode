public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = int.MaxValue;
        for (int i = 0; i < prices.Length; i++)
        {
            var price = prices[i];
            if (price < minPrice)
                minPrice = price;
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }
        return maxProfit;
    }
}