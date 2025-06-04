/**
 * Definition for a binary tree node.
 * This defines the structure of a node in a binary tree.
 */

//Iterative DFS
//Time complexity: O(n) Space complexity: O(n)

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // Create a stack to store pairs of nodes from tree p and q
        var stack = new Stack<(TreeNode, TreeNode)>();
        
        // Push the root nodes of both trees to the stack
        stack.Push((p, q));

        // Loop as long as there are nodes in the stack
        while (stack.Count > 0) {
            // Pop the top pair of nodes from the stack
            var (node1, node2) = stack.Pop();

            // If both nodes are null, continue to the next pair
            if (node1 == null && node2 == null) continue;

            // If one node is null and the other is not, or if their values are different → trees are not the same
            if (node1 == null || node2 == null || node1.val != node2.val) {
                return false;
            }

            // Push the right children of both nodes to the stack (process later)
            stack.Push((node1.right, node2.right));

            // Push the left children of both nodes to the stack (process next)
            stack.Push((node1.left, node2.left));
        }

        // If all corresponding nodes match, the trees are the same
        return true;
    }
}

