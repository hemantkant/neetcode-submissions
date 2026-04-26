// EVEN BETTER (Using Dictionary 🔥)
// ⏱ TC: O(n)
// 🧠 SC: O(n)

// 👉 Instead of moving left one by one, jump directly

// 💡 Idea:

// Store last seen index of character

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var map = new Dictionary<char, int>();

        int left = 0, maxLen = 0;

        for (int right = 0; right < s.Length; right++) {

            if (map.ContainsKey(s[right])) {
                left = Math.Max(left, map[s[right]] + 1);
            }

            map[s[right]] = right;
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}
