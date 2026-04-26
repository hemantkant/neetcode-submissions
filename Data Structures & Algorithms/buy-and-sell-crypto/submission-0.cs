public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0;
        foreach(int price in prices){
            if(price<minPrice){
                minPrice = price;
            }
            int profit = price - minPrice;
            maxProfit = Math.Max(maxProfit,profit);
        }
        return maxProfit;
    }
}
