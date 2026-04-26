// 1. Brute Force
// ⏱ TC: O(n³)
// 🧠 SC: O(n)
// 💡 Idea:
// Generate all substrings
// Check each substring for duplicates

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLen = 0;

        for (int i = 0; i < n; i++) {
            for (int j = i; j < n; j++) {
                var set = new HashSet<char>();
                bool valid = true;

                for (int k = i; k <= j; k++) {
                    if (set.Contains(s[k])) {
                        valid = false;
                        break;
                    }
                    set.Add(s[k]);
                }

                if (valid)
                    maxLen = Math.Max(maxLen, j - i + 1);
            }
        }

        return maxLen;
    }
}
