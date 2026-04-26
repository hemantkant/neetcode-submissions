// Approach 3: Optimal (Two Pointer - Forward Write)
// ⏱ Complexity
// TC: O(n)
// SC: O(1) ✅
// 💡 Core Idea

// Use a write pointer (k):

// Iterate through array
// If element ≠ val → write it at index k
// Increment k

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[k] = nums[i];
            k++;
        }
    }

    return k;
    }
}