// Optimal Approach (Two Pointers)
// ⏱️ Time Complexity (TC): O(n + m)
// We traverse both strings once
// 🧠 Space Complexity (SC): O(n + m)
// We build a new result string

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0, j = 0;
        StringBuilder result = new StringBuilder();

        // Merge alternately
        while (i < word1.Length && j < word2.Length) {
            result.Append(word1[i]);
            result.Append(word2[j]);
            i++;
            j++;
        }

        // Append remaining characters
        while (i < word1.Length) {
            result.Append(word1[i]);
            i++;
        }

        while (j < word2.Length) {
            result.Append(word2[j]);
            j++;
        }

        return result.ToString();
    }
}