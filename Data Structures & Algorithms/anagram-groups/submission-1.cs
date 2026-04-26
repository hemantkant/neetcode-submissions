//TC: O(n*klogk)
//SC:O(n*k)
//Sort each string, Use sorted string as key in dictionary
//Group words with same key
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!dict.ContainsKey(key))
                dict[key] = new List<string>();

            dict[key].Add(word);
        }

        return dict.Values.ToList<List<string>>();
    }
}
