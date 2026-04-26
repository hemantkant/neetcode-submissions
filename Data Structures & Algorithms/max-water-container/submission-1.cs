// BETTER / OPTIMAL APPROACH (Two Pointer)
// 🔥 Core Insight

// Start with maximum width first.

// Use:

// left = 0
// right = n - 1

// Then move pointers inward.

// 🧠 Important Logic

// At each step:

// area = (right - left) * min(height[left], height[right])

// Now key decision:

// 👉 Move the pointer of the smaller height

// Why?

// Because:

// Area depends on the smaller height.
// Moving larger height won't increase height.
// Only hope to improve is finding taller shorter wall.

public class Solution {
    public int MaxArea(int[] height) {
    int left = 0;
    int right = height.Length - 1;
    int maxArea = 0;

    while (left < right) {
        int width = right - left;
        int h = Math.Min(height[left], height[right]);
        int area = width * h;

        maxArea = Math.Max(maxArea, area);

        if (height[left] < height[right]) {
            left++;
        } else {
            right--;
        }
    }

    return maxArea;
}
}
