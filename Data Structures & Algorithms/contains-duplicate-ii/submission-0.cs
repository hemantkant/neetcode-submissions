// Approach 1 — Brute Force
// TC: O(n²)
// SC: O(1)

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                if (nums[i] == nums[j] && Math.Abs(i - j) <= k) {
                    return true;
                }
            }
        }
        return false;
    }
}