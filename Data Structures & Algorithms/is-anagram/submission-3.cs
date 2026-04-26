public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        Dictionary<char,int> count = new Dictionary<char, int>();
        foreach(char c in s){
            if(!count.ContainsKey(c)){
                count[c] = 0;
            }
            count[c]++;
        } 
        foreach(char c in t){
            if(!count.ContainsKey(c)){
                return false;
            }
            count[c]--;
            if(count[c]<0){
                return false;
            }
        }
        // int[] count = new int[26];
        // foreach(char c in s){
        //     count[c-'a']++;
        // } 
        // foreach(char c in t){
        //     count[c-'a']--;
        // }
        // foreach(int val in count){
        //     if(val!=0){
        //         return false;
        //     }
        // }
        return true;
    }
}
