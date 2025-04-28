
Time complexity: O(n)
Space complexity: O(1)

// Definition of a Node in the Linked List
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution {
    public ListNode ReverseList(ListNode head) {
        // Create a pointer 'curr' that starts at the head of the list
        ListNode curr = head;

        // Create a pointer 'prev' which initially points to nothing (null)
        ListNode prev = null;

        // Loop through the list until 'curr' becomes null (end of the list)
        while (curr != null) {
            // 1. Save the next node temporarily before changing anything
            ListNode tmp = curr.next;

            // 2. Reverse the pointer: make 'curr' point back to 'prev' node
            curr.next = prev;

            // 3. Move 'prev' to 'curr' (this node is now the latest reversed one)
            prev = curr;

            // 4. Move 'curr' to the next node (continue moving forward)
            curr = tmp;
        }

        // When the loop ends, 'prev' will be pointing to the new head (reversed list)
        return prev;
    }
}

SOLUTION 2:-
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
    public ListNode ReverseList(ListNode head) 
    {
        // 'curr' will move through the list, starting from head
        ListNode curr = head;

        // 'prev' keeps track of the previous node (initially null)
        ListNode prev = null;

        // 'next' will temporarily store the next node while reversing
        ListNode next = null;

        // Loop through the linked list until we reach the end
        while (curr != null)
        {
            // 1. Save the next node before breaking the link
            next = curr.next;

            // 2. Reverse the current node's pointer
            curr.next = prev;

            // 3. Move 'prev' one step forward (prev becomes curr)
            prev = curr;

            // 4. Move 'curr' one step forward (curr becomes next)
            curr = next;
        }

        // After the loop, 'prev' will be pointing at the new head of the reversed list
        return prev;
    }
}


 


