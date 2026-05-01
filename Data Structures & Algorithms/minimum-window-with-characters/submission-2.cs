// 2. Better Approach (HashMap + Sliding Window)
// 💡 Core Idea

// We maintain:

// countT → frequency of characters in t
// window → frequency inside current window
// have → how many chars matched
// need → total unique chars needed
// ⏱ Complexity
// TC: O(n)
// SC: O(m) (size of t)
// 🧠 Algorithm Steps
// Build countT
// Start with two pointers: l = 0
// Expand r
// When window is valid → shrink l
// Track minimum window

public class Solution {
    public string MinWindow(string s, string t) {
    if (t.Length > s.Length) return "";

    var countT = new Dictionary<char, int>();
    var window = new Dictionary<char, int>();

    foreach (char c in t) {
        if (!countT.ContainsKey(c)) countT[c] = 0;
        countT[c]++;
    }

    int have = 0, need = countT.Count;
    int l = 0;
    int[] res = { -1, -1 };
    int resLen = int.MaxValue;

    for (int r = 0; r < s.Length; r++) {
        char c = s[r];

        if (!window.ContainsKey(c)) window[c] = 0;
        window[c]++;

        if (countT.ContainsKey(c) && window[c] == countT[c]) {
            have++;
        }

        // shrink window
        while (have == need) {
            if ((r - l + 1) < resLen) {
                res[0] = l;
                res[1] = r;
                resLen = r - l + 1;
            }

            window[s[l]]--;

            if (countT.ContainsKey(s[l]) && window[s[l]] < countT[s[l]]) {
                have--;
            }

            l++;
        }
    }

    return resLen == int.MaxValue 
        ? "" 
        : s.Substring(res[0], resLen);
}
}
