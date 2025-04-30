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

public class Solution 
{
    public void ReorderList(ListNode head) 
    {
        if (head == null || head.next == null)
            return;

        // Step 1: Find the middle of the linked list
        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Step 2: Reverse the second half of the list
        // 'second' is the first node of the second half
        ListNode second = slow.next;
        slow.next = null; // Break the list into two parts
        ListNode prev = null; // 'prev' will help reverse the list
        // Reverse the second half
        while (second != null) {
            ListNode temp = second.next; // Save next node
            second.next = prev; // Reverse the link
            prev = second; // Move 'prev' forward
            second = temp; // Move 'second' forward
        }

        // Step 3: Merge the two halves
        ListNode first = head;
        second = prev; // 'prev' is now the head of reversed second half
        while (second != null) {
            ListNode temp1 = first.next; // Save next of first part
            ListNode temp2 = second.next; // Save next of second part
            first.next = second; // Link first node to second node
            second.next = temp1; // Link second node to next node of first part
            // Move pointers forward
            first = temp1;
            second = temp2;
        }
        //The provided code merges the two halves by iterating through the first half of the list. 
        //At each step, it unlinks a node from the second half and links it into the first half. 
        //This results in the desired ordering of nodes.
    }
}



        

        
    

