// 2. Better Approach
// ⏱ TC: O(n²)
// 🧠 SC: O(n)
// 💡 Idea:
// Fix left index i
// Expand right j
// Use a HashSet to track duplicates

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLen = 0;

        for (int i = 0; i < s.Length; i++) {
            var set = new HashSet<char>();

            for (int j = i; j < s.Length; j++) {
                if (set.Contains(s[j]))
                    break;

                set.Add(s[j]);
                maxLen = Math.Max(maxLen, j - i + 1);
            }
        }

        return maxLen;
    }
}
