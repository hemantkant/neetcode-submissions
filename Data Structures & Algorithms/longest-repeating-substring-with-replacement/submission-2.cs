// Optimal (Important Trick)
// 💭 Key Optimization

// 👉 We DO NOT decrease maxFreq

// This is the tricky part.

// 🤯 Why it works?

// Even if maxFreq becomes outdated:

// It only makes window larger than valid
// But we shrink only when necessary

// 👉 This guarantees correctness

// Complexity
// TC: O(n)
// SC: O(1)

public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];

    int left = 0;
    int maxFreq = 0;
    int maxLen = 0;

    for (int right = 0; right < s.Length; right++) {
        freq[s[right] - 'A']++;

        maxFreq = Math.Max(maxFreq, freq[s[right] - 'A']);

        int windowSize = right - left + 1;

        if (windowSize - maxFreq > k) {
            freq[s[left] - 'A']--;
            left++;
        }

        maxLen = Math.Max(maxLen, right - left + 1);
    }

    return maxLen;
    }
}
