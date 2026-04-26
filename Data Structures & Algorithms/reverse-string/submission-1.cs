// Reverse String
// ✅ Optimal Approach (Two Pointers)
// ⏱️ Time Complexity (TC)

// O(n) → we traverse half of the array

// 🧠 Space Complexity (SC)

// O(1) → in-place, no extra space

public class Solution {
    public void ReverseString(char[] s)
{
    int left = 0;
    int right = s.Length - 1;

    while (left < right)
    {
        // swap
        char temp = s[left];
        s[left] = s[right];
        s[right] = temp;

        left++;
        right--;
    }
}
}