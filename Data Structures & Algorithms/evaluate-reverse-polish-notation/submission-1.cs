public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string token in tokens){
            if(token=="+" || token=="-" || token=="*" || token=="/"){
                int b = stack.Pop();
                int a = stack.Pop();
                if(token=="+"){
                    stack.Push(a+b);
                }
                else if(token=="-"){
                    stack.Push(a-b);
                }
                else if(token=="*"){
                    stack.Push(a*b);
                }
                else{
                    stack.Push(a/b);
                }
            }
            else{
                stack.Push(int.Parse(token));
            }
        }
        return stack.Pop();
    }
}
