public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>(){
            {')', '('},
            {'}','{'},
            {']','['}
        };
        foreach(char c in s){
            if(map.ContainsKey(c)){
                if(stack.Count==0 || stack.Pop() != map[c]){
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }
            return stack.Count==0;
    }
}
