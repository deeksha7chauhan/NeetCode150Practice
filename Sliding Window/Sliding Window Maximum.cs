public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums == null || k <= 0)
            return new int[0];

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        int ri = 0;

        // Use a deque to store indices of useful elements in the current window
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++) {
            // Remove indices that are out of the current window (left side)
            while (deque.Count > 0 && deque.First.Value < i - k + 1) {
                deque.RemoveFirst();
            }

            // Remove indices of all elements smaller than current element (they are useless)
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) {
                deque.RemoveLast();
            }

            // Add current element index to the deque
            deque.AddLast(i);

            // If the window is formed (i >= k - 1), record the max (at deque front)
            if (i >= k - 1) {
                result[ri++] = nums[deque.First.Value];
            }
        }

        return result;
    }
}
_______________________________________________________________________________________________________________________________________________________________________
#solution2
public class Solution 
{
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        int n = nums.Length;
        int[] result = new int[n-k+1]; //Result array will have n - k + 1 elements
        var dq = new LinkedList<int>(); // deque to store indexes of potential max elements
        int l = 0, r=0;
        
        while(r < n)
        {
            while(dq.Count>0 && nums[dq.Last.Value]< nums[r])
            {
                dq.RemoveLast();
            }
            dq.AddLast(r);

            if(l>dq.First.Value)
            {
                dq.RemoveFirst();
            }
            if ((r + 1) >= k) 
            {
                result[l] = nums[dq.First.Value];
                l++;
            }
            r++;

        }
        return result;      
    }
}
// //You keep indices in the deque (q).

// The deque always keeps the largest element's index at the front for the current window.

// Before adding a new index, you:

// Remove from the back all indices of elements smaller than the new element.

// Remove from the front if it is outside the current window.
