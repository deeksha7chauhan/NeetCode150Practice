public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0, l = 0, r = heights.Length - 1;
        while (l < r) {
            res = Math.Max(res, Math.Min(heights[l], heights[r]) * (r - l));
            if (heights[l] < heights[r]) l++;
            else r--;
        }
        return res;
    }
}

#Time complexity: O(n)
#Space complexity: O(1)
