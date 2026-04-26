// Optimal Approach (Index Placement / Cyclic Sort Idea)
// 💡 Core Idea

// 👉 Place each number x at index x-1

// Correct position:
// 1 → index 0
// 2 → index 1
// 3 → index 2
// ...

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            while (nums[i] >= 1 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                int correctIndex = nums[i] - 1;

                // swap
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
        }

        for (int i = 0; i < n; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }

        return n + 1;
    }
}