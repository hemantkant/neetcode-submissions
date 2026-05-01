// Approach 3 — Optimal (Sliding Window + HashSet)

// 🔥 THIS is the expected solution

// ⏱ TC: O(n)
// 📦 SC: O(k)
// 💡 Core Idea:

// Maintain a window of size k

// 👉 If duplicate exists inside window → return true

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();

    for (int i = 0; i < nums.Length; i++) {
        if (set.Contains(nums[i])) {
            return true;
        }

        set.Add(nums[i]);

        // maintain window size = k
        if (set.Count > k) {
            set.Remove(nums[i - k]);
        }
    }

    return false;
    }
}