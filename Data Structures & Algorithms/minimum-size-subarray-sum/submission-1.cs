// 3. Optimal Approach (Sliding Window) ✅
// 🚀 Key Insight

// Because:
// 👉 All numbers are positive

// We can:

// Expand window → sum increases
// Shrink window → sum decreases
// ⏱ Complexity
// TC: O(n)
// SC: O(1)
// 💡 Idea
// Use two pointers: left, right
// Expand right → increase sum
// When sum ≥ target:
// Update answer
// Shrink from left

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
    int sum = 0;
    int minLen = int.MaxValue;

    for (int right = 0; right < nums.Length; right++) {
        sum += nums[right];

        while (sum >= target) {
            minLen = Math.Min(minLen, right - left + 1);
            sum -= nums[left];
            left++;
        }
    }

    return minLen == int.MaxValue ? 0 : minLen;
    }
}