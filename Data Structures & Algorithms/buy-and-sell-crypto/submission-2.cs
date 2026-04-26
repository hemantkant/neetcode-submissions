// 1. Brute Force Approach
// ⏱️ TC: O(n²)
// 🧠 SC: O(1)
// Idea:
// Try every possible pair (buy, sell) where j > i

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++) {
            for (int j = i + 1; j < prices.Length; j++) {
                int profit = prices[j] - prices[i];
                maxProfit = Math.Max(maxProfit, profit);
            }
        }

        return maxProfit;    
    }
}
