public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pair = new int[position.Length][];
        for (int i = 0; i < position.Length; i++) {
            pair[i] = new int[] { position[i], speed[i] };
        }
        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        Stack<double> stack = new Stack<double>();
        foreach (var p in pair) {
            stack.Push((double)(target - p[0]) / p[1]);
            if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
                stack.Pop();
            }
        }
        return stack.Count;
    }
}
#Time complexity: O(nlogn)
#Space complexity: O(n)

#stack.ElementAt(0) → Top element (3)
#stack.ElementAt(1) → Second element (2)
#stack.ElementAt(2) → Third element (1)

    stack.Peek()//= element[0], element at the top which is recently pushed. <= stack.ElementAt(1) // = element[1],element pushed in the beginning)
    Since we are always pushing 2 elements in the stack which is the nearest to the target since we reversed the array and the second on is the element next to first element.
