public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }

        // Step 1: Clone each node and insert it between the original node and its next
        Node l1 = head;
        while (l1 != null) {
            Node l2 = new Node(l1.val);    // clone of current node
            l2.next = l1.next;             // link clone's next to original's next
            l1.next = l2;                  // insert clone right after original
            l1 = l2.next;                  // move to next original node
        }

        // Step 2: Assign random pointers for the cloned nodes
        l1 = head;
        while (l1 != null) {
            // l1.random is the original's random
            // l1.next is the clone
            l1.next.random = (l1.random != null) ? l1.random.next : null;
            l1 = l1.next.next;  // move to next original node
        }

        // Step 3: Separate the cloned list from the original list
        l1 = head;
        Node newHead = head.next;  // head of the cloned list
        while (l1 != null) {
            Node l2 = l1.next;        // clone node
            l1.next = l2.next;        // restore original node's next
            l2.next = (l2.next != null) ? l2.next.next : null; // link clone's next
            l1 = l1.next;             // move to next original node
        }

        return newHead;  // return deep copy head
    }
}
#Time Complexity: O(n)  Space Complexity: O(1) (excluding the returned cloned list)
