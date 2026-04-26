// Approach 3 — Optimal (HashMap / Dictionary)
//This is the expected interview solution.
// TC: O(n)
// SC: O(n)
// Core Idea:
// Instead of searching for:
// nums[i] + nums[j] = target
// We rearrange:
// nums[j] = target - nums[i]

// For each number:

// Calculate complement = target - current
// Check if complement already exists
// If yes → done
// If no → store current number in dictionary

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        return new int[0];
    }
}
