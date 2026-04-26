public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int maxLen = 0;
        int maxFreq = 0;
        int[] freq = new int[26];
        for(int right = 0; right<s.Length; right++){
            freq[s[right]-'A']++;
            maxFreq = Math.Max(freq[s[right]-'A'], maxFreq);
            int window = right-left+1;
            if(window-maxFreq>k){
                freq[s[left]-'A']--;
                left++;
            }
            maxLen = Math.Max(right-left+1, maxLen);
        }
        return maxLen;
    }
}
