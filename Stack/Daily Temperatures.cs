public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int n = temperatures.Length;
        int[] final = new int[n];
        Stack<int[]> indices = new Stack<int[]>();
        for (int i = 0; i < n; i++)
        {
            int current = temperatures[i];
            while(indices.Count>0 && current > indices.Peek()[0])
            {
                int[] pair = indices.Pop();
                final[pair[1]] = i - pair[1];
            }
            indices.Push(new int[] {current, i});
        }
        return final;
        
    }
}
#Time complexity: O(n)
Space complexity: O(n)


public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int [] answers = new int[n];
        Stack<int> stack = new Stack<int>();

        for(int i = n-1; i >=0; i--){
            while(stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()]){
                stack.Pop();
            }

            answers[i] = stack.Count == 0 ? 0 : stack.Peek() - i;
            stack.Push(i);
        }
        
        return answers;
    }
}
