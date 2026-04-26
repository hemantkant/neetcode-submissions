public class Solution {
    public string MinWindow(string s, string t) {
       if(t.Length>s.Length){
        return "";
       } 
       Dictionary<char, int> need = new Dictionary<char, int>();
        foreach(char c in t){
            if(!need.ContainsKey(c)){
                need[c] = 0;
            }
            need[c]++;
        }
        Dictionary<char, int> window = new Dictionary<char, int>();   
        int have = 0;
        int needCount = need.Count;
        int left = 0;
        int minLen = int.MaxValue;
        int startIndex = 0;
        for(int right = 0; right<s.Length; right++){
            char c = s[right];
            if(!window.ContainsKey(c)){
                window[c] = 0;
            }
            window[c]++;
            if(need.ContainsKey(c) && window[c] == need[c]){
                have++;
            }
            while(have==needCount){
                if((right-left+1)<minLen){
                    minLen = right-left+1;
                    startIndex = left;
                }
                char leftChar = s[left];
                window[leftChar]--;
                if(need.ContainsKey(leftChar) && window[leftChar] < need[leftChar]){
                    have--;
                }
                left++;
            }
        }
        return minLen == int.MaxValue ? "" : s.Substring(startIndex, minLen);     
    }
}
