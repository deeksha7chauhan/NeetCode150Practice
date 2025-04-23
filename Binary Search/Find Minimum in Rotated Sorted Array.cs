public class Solution {
    // Function to find the minimum element in a rotated sorted array
    public int FindMin(int[] nums) {
        int l = 0;                          // Left pointer
        int r = nums.Length - 1;           // Right pointer

        // Binary search loop
        while (l < r) {
            int mid = l + (r - l) / 2;     // Calculate mid index (avoids overflow)

            // If middle element is greater than the rightmost element,
            // the smallest value must be to the right of mid.
            if (nums[mid] > nums[r]) {
                l = mid + 1;               // Move left pointer to mid + 1
            } else {
                // Otherwise, the smallest value is at mid or to the left of mid
                r = mid;                   // Move right pointer to mid
            }
        }

        // After the loop, l == r and points to the smallest value
        return nums[l];
    }
}
#Time Complexity: O(log n)
#Space Complexity: O(1)
