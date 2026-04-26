// Optimal Approach (Two Pointers)
//TC: O(n)
//SC: O(1)
//Core Idea
// Use two pointers:
// i → last unique element index
// j → scanning pointer
// Logic
// Start i = 0
// Loop j from 1 → n-1
// If nums[j] != nums[i]
// Move i++
// Copy nums[j] to nums[i]
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