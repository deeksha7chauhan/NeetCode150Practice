public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stacker = new Stack<int>();

        foreach (string s in tokens) {
            if (s == "+") {
                stacker.Push(stacker.Pop() + stacker.Pop());
            }
            else if (s == "-") {
                int a = stacker.Pop();
                int b = stacker.Pop();
                stacker.Push(b - a); // order matters
            }
            else if (s == "/") {
                int a = stacker.Pop();
                int b = stacker.Pop();
                stacker.Push(b / a); // integer division
            }
            else if (s == "*") {
                stacker.Push(stacker.Pop() * stacker.Pop());
            }
            else {
                stacker.Push(int.Parse(s));
            }
        }

        return stacker.Pop();
    }
}

