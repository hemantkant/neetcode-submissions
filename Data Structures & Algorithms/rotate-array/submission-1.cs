// Approach 3: Optimal (Reverse Trick) ⭐
// ⏱ Time Complexity: O(n)
// 🧠 Space Complexity: O(1)
// 💡 Core Idea

// Instead of shifting, we reverse parts of the array.

// ⚡ Steps
// Reverse entire array
// Reverse first k elements
// Reverse remaining n-k elements

public class Solution {
    public void Rotate(int[] nums, int k) {
    int n = nums.Length;
    k = k % n;

    Reverse(nums, 0, n - 1);
    Reverse(nums, 0, k - 1);
    Reverse(nums, k, n - 1);
}

private void Reverse(int[] nums, int left, int right) {
    while (left < right) {
        int temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;

        left++;
        right--;
    }
}
}