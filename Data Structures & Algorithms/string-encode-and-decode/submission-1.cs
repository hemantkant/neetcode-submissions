// OPTIMAL SOLUTION
// ⏱ Time & Space Complexity
// Encode:
// TC: O(N)
// SC: O(N)
// Decode:
// TC: O(N)
// SC: O(N)

// Where N = total characters in all strings.

public class Solution {

    // Encodes a list of strings to a single string.
    public string Encode(IList<string> strs)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string s in strs)
        {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }

        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            // Find the delimiter '#'
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }

            // Extract length
            int length = int.Parse(s.Substring(i, j - i));

            // Move pointer after '#'
            j++;

            // Extract string of given length
            string word = s.Substring(j, length);
            result.Add(word);

            // Move pointer to next encoded part
            i = j + length;
        }

        return result;
    }
}
