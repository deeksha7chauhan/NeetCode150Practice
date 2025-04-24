#In a sorted array if the first element is greaer than the target element then all the elements in the array would be greater too.
public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        // Perform binary search
        while (l <= r) {
            int mid = (l + r) / 2;

            // ✅ If target is found at mid, return its index
            if (target == nums[mid]) {
                return mid;
            }

            // 🔍 Check if the left half [l...mid] is sorted
            if (nums[l] <= nums[mid]) {
                // 🧠 If target is NOT in the left sorted half, search right
                if (target > nums[mid] || target < nums[l]) {
                    l = mid + 1;
                } else {
                    // 🔁 Else, search left half
                    r = mid - 1;
                }
            }
            // 🔍 Else, the right half [mid...r] must be sorted
            else {
                // 🧠 If target is NOT in the right sorted half, search left
                if (target < nums[mid] || target > nums[r]) {
                    r = mid - 1;
                } else {
                    // 🔁 Else, search right half
                    l = mid + 1;
                }
            }
        }

        // ❌ Target not found
        return -1;
    }
}
