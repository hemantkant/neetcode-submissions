// Approach 2 — Better (HashMap)
// TC: O(n)
// SC: O(n)
// Idea:
// Store last index of each number
// If seen before:
// check distance

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (map.ContainsKey(nums[i])) {
                if (i - map[nums[i]] <= k) {
                    return true;
                }
            }
            map[nums[i]] = i;
        }

        return false;
    }
}