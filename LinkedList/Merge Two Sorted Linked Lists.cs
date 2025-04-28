#**Iteration**
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        //creating a new node called dummy. Its val is 0. next is null by default. dummy node because it won't be part of the final answer
// dummy
//   |
//  [0] -> null

        ListNode dummy = new ListNode(0);

      //node is pointing to the same memory as dummy. Both dummy and node are pointing to the same first node ([0]).
        ListNode node = dummy;
// dummy, node
//   |
//  [0] -> null


      //node is the pointer that will move forward and build the merged linked list step-by-step.
      //dummy stays still at the beginning, so after building everything, you can easily return dummy.next as the real answer (skipping the dummy 0 node).

        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                node.next = list1;
                list1 = list1.next;
            } else {
                node.next = list2;
                list2 = list2.next;
            }
            node = node.next;
        }

        if (list1 != null) {
            node.next = list1;
        } else {
            node.next = list2;
        }

        return dummy.next;
    }
}
Time complexity: O(n+m)
Space complexity: O(1)


**Recursion**
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) {
            return list2;
        }
        if (list2 == null) {
            return list1;
        }
        if (list1.val <= list2.val) {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        } else {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}

Time complexity: O(n+m)
Space complexity: O(n+m)
