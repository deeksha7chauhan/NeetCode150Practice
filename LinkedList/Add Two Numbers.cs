/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val = 0, ListNode next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // Dummy (sentinel) node eliminates special-case logic for the first real node.
        ListNode dummy = new ListNode(); 
        ListNode cur = dummy;            // ‘cur’ always points to the last node in the result list.

        int carry = 0;                   // Carry that bubbles to the next digit (0-9 → 0, 10-18 → 1, etc.)
        
        // Continue until both lists are exhausted *and* no carry remains.
        while (l1 != null || l2 != null || carry != 0) {

            // Get current digit values; if one list is shorter, treat its digit as 0.
            int v1 = (l1 != null) ? l1.val : 0;
            int v2 = (l2 != null) ? l2.val : 0;

            // Add the two digits plus any carry from the previous position.
            int sum = v1 + v2 + carry;

            carry = sum / 10;            // New carry is 1 if sum ≥ 10, otherwise 0.
            int digit = sum % 10;        // The ones-place digit to store in the new node.

            // Append the digit to the result list.
            cur.next = new ListNode(digit);
            cur = cur.next;              // Advance the result pointer.

            // Advance input list pointers if they still have nodes.
            l1 = (l1 != null) ? l1.next : null;
            l2 = (l2 != null) ? l2.next : null;
        }

        // The first node was the dummy; the real result starts at dummy.next.
        return dummy.next;
    }
}


#Time complexity: O(m+n)
#Space complexity:O(1) extra space.O(max(m,n)) for the output list.
