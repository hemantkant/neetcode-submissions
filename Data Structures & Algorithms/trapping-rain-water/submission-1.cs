// Optimal Approach (Two Pointer)
// ⏱ TC: O(n)
// 📦 SC: O(1)
// 🔥 Intuition Deep Dive

// If:

// leftMax < rightMax

// We KNOW that:

// min(leftMax, rightMax) = leftMax

// So we don’t need right side anymore.

public class Solution {
    public int Trap(int[] height) 
{
    int left = 0;
    int right = height.Length - 1;

    int leftMax = 0;
    int rightMax = 0;

    int total = 0;

    while (left < right)
    {
        if (height[left] < height[right])
        {
            if (height[left] >= leftMax)
                leftMax = height[left];
            else
                total += leftMax - height[left];

            left++;
        }
        else
        {
            if (height[right] >= rightMax)
                rightMax = height[right];
            else
                total += rightMax - height[right];

            right--;
        }
    }

    return total;
}
}
