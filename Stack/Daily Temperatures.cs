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
