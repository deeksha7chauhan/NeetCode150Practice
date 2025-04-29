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
    public bool HasCycle(ListNode head) 
{
    if (head == null)
        return false;

    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;         // move slow by 1 step
        fast = fast.next.next;     // move fast by 2 steps

        if (slow == fast)
            return true;           // cycle found
    }

    return false;                  // fast reached end -> no cycle
}
//Time complexity: O(n) Space complexity: O(1)
//After detecting a meeting point (where slow == fast):
// Reset one pointer (slow) to the head of the list.
// Keep the other pointer (fast) where it met slow.
// Move both pointers one step at a time.
// The point where they meet again → is the start of the cycle
//ListNode pointer = head;

            // while (pointer != slow)
            // {
            //     pointer = pointer.next;
            //     slow = slow.next;
            // }

            // return pointer;

}


//SOLUTION 2 //Time complexity: O(n) Space complexity: O(n)
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
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> seen = new HashSet<ListNode>();
        ListNode cur = head;
        while (cur != null) {
            if (seen.Contains(cur)) {
                return true;
            }
            seen.Add(cur);
            cur = cur.next;
        }
        return false;
    }
}
