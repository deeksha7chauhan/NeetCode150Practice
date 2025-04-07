#Dynamic programming
public class Solution {
    public int MaxProfit(int[] prices) {
        int mxP = 0;
        int minBuy = prices[0];

        foreach (int sell in prices) {
            mxP = Math.Max(mxP, sell - minBuy);
            minBuy = Math.Min(minBuy, sell);
        }
        return mxP;
    }
}
#Two Pointers
public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        int maxP = 0;

        while (r < prices.Length) {
            if (prices[l] < prices[r]) {
                int profit = prices[r] - prices[l];
                maxP = Math.Max(maxP, profit);
            } else {
                l = r;
            }
            r++;
        }
        return maxP;
    }
}
Time complexity O(n)
Space Complexity O(1)
