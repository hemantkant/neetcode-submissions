// 3. Optimal Approach (Sliding Window + Frequency Count)
// 💡 Core Idea

// Instead of sorting → use frequency arrays

// 👉 Two arrays:

// count1 → freq of s1
// count2 → freq of current window in s2

// 👉 If both arrays equal → permutation found

// ⏱ Complexity
// TC: O(n)
// SC: O(1) (26 chars only)

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int[] count1 = new int[26];
        int[] count2 = new int[26];

        // Fill count1 and first window of s2
        for (int i = 0; i < s1.Length; i++) {
            count1[s1[i] - 'a']++;
            count2[s2[i] - 'a']++;
        }

        // Check initial window
        if (Matches(count1, count2)) return true;

        // Sliding window
        for (int i = s1.Length; i < s2.Length; i++) {
            count2[s2[i] - 'a']++; // add right
            count2[s2[i - s1.Length] - 'a']--; // remove left

            if (Matches(count1, count2)) return true;
        }

        return false;
    }

    private bool Matches(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}
