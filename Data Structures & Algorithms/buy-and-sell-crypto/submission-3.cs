// 2. Better Approach (Track Minimum)
// ⏱️ TC: O(n)
// 🧠 SC: O(1)

// Idea:
// Instead of checking all pairs:

// Keep track of minimum price so far
// At each step:
// Calculate profit if sold today

public class Solution {
    public int MaxProfit(int[] prices) {
        //int minPrice = prices[0];
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        foreach(int price in prices){
            minPrice = Math.Min(minPrice, price);
            // if(price<minPrice){
            //     minPrice = price;
            // }
            int profit = price - minPrice;
            maxProfit = Math.Max(maxProfit,profit);
        }
        return maxProfit;
    }
}
