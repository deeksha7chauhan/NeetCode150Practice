public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {
        int l = 1;
        int r = piles.Max();
        int res = r;

        while (l <= r)
        {
            int mid = l + (r - l) / 2; // candidate eating speed
            long totTime = 0;

            foreach (int p in piles)
            {
                totTime += (int)Math.Ceiling((double)p / mid); // use mid here, not k
            }

            if (totTime <= h)
            {
                res = mid;    // mid is a possible answer, try to go lower
                r = mid - 1;
            }
            else
            {
                l = mid + 1;  // too slow, need a faster eating speed
            }
        }

        return res;
    }
}

#Time complexity: 
O(n∗logm)
Space complexity: 
O(1)
