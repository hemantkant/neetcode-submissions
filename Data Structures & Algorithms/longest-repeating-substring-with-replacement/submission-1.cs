// 2️⃣ Better (Sliding Window + Recalculate maxFreq)
// 💭 Idea

// Use sliding window, but recompute maxFreq every time.

// ⏱ Complexity
// TC: O(26 * n) ≈ O(n)
// SC: O(1)

public class Solution {
    public int CharacterReplacement(string s, int k)
{
    int[] freq = new int[26];
    int left = 0;
    int maxLen = 0;

    for (int right = 0; right < s.Length; right++)
    {
        // Add current character
        freq[s[right] - 'A']++;

        // Recalculate maxFreq for current window
        int maxFreq = 0;
        for (int i = 0; i < 26; i++)
        {
            maxFreq = Math.Max(maxFreq, freq[i]);
        }

        // Check if window is invalid
        while ((right - left + 1) - maxFreq > k)
        {
            freq[s[left] - 'A']--;
            left++;

            // Recalculate maxFreq again after shrinking
            maxFreq = 0;
            for (int i = 0; i < 26; i++)
            {
                maxFreq = Math.Max(maxFreq, freq[i]);
            }
        }

        maxLen = Math.Max(maxLen, right - left + 1);
    }

    return maxLen;
}
}
