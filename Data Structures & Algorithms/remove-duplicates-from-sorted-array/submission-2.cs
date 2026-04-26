// 3. Optimal Approach (Two Pointers)
// 🔥 TC: O(n)
// 🔥 SC: O(1)
// 🧠 Core Idea
// Use two pointers:
// i → last unique element index
// j → scanning pointer

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int i = 0;

        for (int j = 1; j < nums.Length; j++) {
            if (nums[j] != nums[i]) {
                i++;
                nums[i] = nums[j];
            }
        }

        return i + 1;
    }
}