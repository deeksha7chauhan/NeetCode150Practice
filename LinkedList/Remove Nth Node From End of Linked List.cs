/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode dummy = new ListNode(0, head); // Step 1: Create dummy node

        //ListNode dummy = new ListNode(0); // Step 1: Create dummy node with value 0
        //dummy.next = head;                // Step 2: Point it to the actual head

ListNode left = dummy; // 'left' pointer starts at dummy
ListNode right = head; // 'right' pointer starts at head

// Step 2: Move right pointer 'n' steps forward
while (n > 0) {
    right = right.next;
    n--;
}

// Step 3: Move both left and right one step until right reaches null
while (right != null) {
    left = left.next;
    right = right.next;
}

// Step 4: Remove the nth node
left.next = left.next.next;

// Step 5: Return the modified list (skip dummy)
return dummy.next;
//Start left at dummy	So left is always before the node you want to delete.
//Dummy node	Helps handle head deletion safely.
//Left at dummy	Clean, no special cases needed.

//Key points
// Create a dummy node before head: Helps safely remove the head if needed.
// dummy.next = head
// Initialize two pointers:left → starts at dummy. right → starts at head.
//Move right pointer n steps forward:
//Creates a gap of n-1 nodes between left and right, because slow is already at dummy (0)
// Move left and right together:
//One step at a time until right reaches the end (null).
// At this point: left is standing just before the node to be deleted.
//Delete the target node:
// Adjust left.next to skip over the unwanted node:
// left.next = left.next.next;
// Return the modified list:
// return dummy.next (new head after removal).
 
 //Time	O(n)  Space	O(1)
        
    }
}
