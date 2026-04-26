// 3. Optimal Approach (Sorting + Two Pointer) ⭐
// ⏱ TC: O(n³)
// 🧠 SC: O(1) (ignoring output)
// 💡 Core Idea

// 👉 Sort array
// 👉 Fix 2 numbers → use two pointers for remaining 2

// 🔍 Algorithm
// Sort array
// Fix first index i
// Fix second index j
// Use two pointers:
// left = j + 1
// right = n - 1

public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
    var result = new List<List<int>>();
    int n = nums.Length;

    for (int i = 0; i < n - 3; i++) {
        if (i > 0 && nums[i] == nums[i - 1]) continue;

        for (int j = i + 1; j < n - 2; j++) {
            if (j > i + 1 && nums[j] == nums[j - 1]) continue;

            int left = j + 1;
            int right = n - 1;

            while (left < right) {
                long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                if (sum == target) {
                    result.Add(new List<int> {
                        nums[i], nums[j], nums[left], nums[right]
                    });

                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                }
                else if (sum < target) {
                    left++;
                }
                else {
                    right--;
                }
            }
        }
    }

    return result;
    }
}