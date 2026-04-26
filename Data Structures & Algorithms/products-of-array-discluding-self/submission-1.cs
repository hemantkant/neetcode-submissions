// Final Optimal Code (Interview Version)
// ⏱ Complexity
// Time Complexity: O(n)
// Space Complexity: O(1) (excluding output array)

// Core Idea

// Instead of dividing:

// For each index i:

// result[i] = (product of elements before i)
//             *
//             (product of elements after i)

// We calculate:

// Prefix product
// Suffix product

public class Solution {
    public int[] ProductExceptSelf(int[] nums)
{
    int n = nums.Length;
    int[] result = new int[n];

    // Step 1: Build prefix product
    result[0] = 1;
    for (int i = 1; i < n; i++)
    {
        result[i] = result[i - 1] * nums[i - 1];
    }

    // Step 2: Multiply with suffix product
    int suffix = 1;
    for (int i = n - 1; i >= 0; i--)
    {
        result[i] *= suffix;
        suffix *= nums[i];
    }

    return result;
}
}
