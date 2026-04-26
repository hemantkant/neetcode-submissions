// TC: O(m + n)
// SC: O(1)
// Core Insight:
// nums1 already has extra space at the end
// Fill it from the back

// Strategy:
// Use 3 pointers:
// i = m - 1 → last valid element in nums1
// j = n - 1 → last element in nums2
// k = m + n - 1 → last position in nums1
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0) {
            if (nums1[i] > nums2[j]) {
                nums1[k] = nums1[i];
                i--;
            } else {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        while (j >= 0) {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
}