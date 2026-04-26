// Optimal Approach (Two Pointers)
// Time Complexity (TC)
// O(n) → we traverse half of the array
// Space Complexity (SC)
// O(1) → in-place, no extra space
// Intuition
// You don’t need extra array
// Just swap first with last, second with second-last, etc.
// This is exactly what two pointers do:
// left starts from beginning
// right starts from end
// Swap and move inward

public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length-1;
        while(left<right){
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }
}