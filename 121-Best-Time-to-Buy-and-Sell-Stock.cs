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
// Timeout
// int profit = 0;
// for (int i = 0; i < prices.Length; i++)
// {
//     var priceI = prices[i];
//     for (int j = 0; j < prices.Length; j++)
//     {   
//         var priceJ = prices[j];
//         if (priceI - priceJ > 0 && i > j)
//             profit = Math.Max(profit, priceI - priceJ);
//     }
// }
// return profit;