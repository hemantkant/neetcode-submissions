public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(string word in strs){
            int[] count = new int[26];
            foreach(char c in word){
                count[c-'a']++;
            }
            string anaWord = string.Join("#",count);
            if(!dict.ContainsKey(anaWord)){
                dict[anaWord] = new List<string>();
            }
            dict[anaWord].Add(word);
        }
        return dict.Values.ToList<List<string>>();
    }
}
