public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs){
            sb.Append(s.Length);
            sb.Append("#");
            sb.Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        if (string.IsNullOrEmpty(s)){return res;}
        int i = 0;
        while(i<s.Length){
            int j = i;
            while(s[j]!= '#'){
                j++;
            }
            int len = int.Parse(s.Substring(i,j-i));
            j++;
            string word = s.Substring(j,len);
            res.Add(word);
            i = j+len;
        }
        return res;
   }
}
