// OPTIMAL APPROACH (Character Count Key)

// Now we remove sorting cost.
// Instead of sorting:
// Count frequency of 26 letters
// Build a unique key from frequency array
// 💡 Idea
// For "act":
// a=1, c=1, t=1
// Key:
// #1#0#1#0#0#0....#1
// Two words with same counts → same key.
// No sorting needed.
// ⏱ Complexity
// Time Complexity: O(n * k)
// Space Complexity: O(n * k)

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

    foreach (var word in strs)
    {
        int[] count = new int[26];

        foreach (char c in word)
        {
            count[c - 'a']++;
        }

        string key = string.Join("#", count);

        if (!dict.ContainsKey(key))
            dict[key] = new List<string>();

        dict[key].Add(word);
    }

    return dict.Values.ToList<List<string>>();
    }
}
