// 3. Optimal Approach (Monotonic Deque)
// ⏱ TC: O(n)
// 📦 SC: O(k)
// 🔥 Core Idea (VERY IMPORTANT)

// We maintain a deque (double-ended queue) that stores indices, and:

// Rules:
// Remove smaller elements from back
// → They can never be max again
// Remove out-of-window elements from front
// Front always = max element index

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
    int n = nums.Length;
    int[] result = new int[n - k + 1];
    LinkedList<int> deque = new LinkedList<int>(); // stores indices

    for (int i = 0; i < n; i++) {

        // 1. Remove indices out of window
        if (deque.Count > 0 && deque.First.Value <= i - k) {
            deque.RemoveFirst();
        }

        // 2. Remove smaller elements from back
        while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) {
            deque.RemoveLast();
        }

        // 3. Add current index
        deque.AddLast(i);

        // 4. Add result when window is formed
        if (i >= k - 1) {
            result[i - k + 1] = nums[deque.First.Value];
        }
    }

    return result;
}
}
