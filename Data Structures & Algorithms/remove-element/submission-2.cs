// BONUS: Swap with End (When Order Doesn't Matter)

// 👉 Since order doesn't matter, we can optimize writes

// ⏱ Complexity
// TC: O(n)
// SC: O(1)
// 💡 Idea
// Use two pointers:
// i from start
// n from end
// If nums[i] == val → swap with last

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
    int n = nums.Length;

    while (i < n)
    {
        if (nums[i] == val)
        {
            nums[i] = nums[n - 1];
            n--;
        }
        else
        {
            i++;
        }
    }

    return n;
    }
}