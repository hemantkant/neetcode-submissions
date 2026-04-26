// 3. Optimal Approach (Prefix Sum + HashMap)
// ⏱ TC: O(n)
// 🧠 SC: O(n)
// 💡 Core Insight

// We use this equation:

// currentSum - previousSum = k

// 👉 Rearranged:

// previousSum = currentSum - k

// So:

// If we already saw a prefix sum = currentSum - k
// Then subarray exists ending at current index

public class Solution {
    public int SubarraySum(int[] nums, int k) {
    Dictionary<int, int> map = new Dictionary<int, int>();
    map[0] = 1;

    int count = 0;
    int currentSum = 0;

    foreach (int num in nums) {
        currentSum += num;

        if (map.ContainsKey(currentSum - k)) {
            count += map[currentSum - k];
        }

        if (!map.ContainsKey(currentSum)) {
            map[currentSum] = 0;
        }

        map[currentSum]++;
    }

    return count;
}
}