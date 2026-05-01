// 3. Optimal Approach (Sliding Window / Two Pointer)
// ⏱️ TC: O(n)
// 🧠 SC: O(1)
// 💡 Idea:

// Use two pointers:

// l = buy day
// r = sell day

public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0; // buy
    int r = 1; // sell
    int maxProfit = 0;

    while (r < prices.Length) {
        if (prices[r] > prices[l]) {
            int profit = prices[r] - prices[l];
            maxProfit = Math.Max(maxProfit, profit);
        } else {
            l = r; // new minimum
        }
        r++;
    }

    return maxProfit;
    }
}
