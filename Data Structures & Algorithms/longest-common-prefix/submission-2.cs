// Optimal Approach (Sorting Trick)
// This is a very clever trick.
// Key Observatio
// After sorting strings:
// Only first and last string determine the prefix.
// TC: O(N log N + M)
// SC: O(1)

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);

    string first = strs[0];
    string last = strs[strs.Length - 1];

    int i = 0;

    while (i < first.Length && i < last.Length && first[i] == last[i])
        i++;

    return first.Substring(0, i);
    }
}