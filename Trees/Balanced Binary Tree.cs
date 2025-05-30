/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root) 
    {
        // Call the recursive helper function and check the first value (isBalanced)
        return Dfs(root)[0] == 1;
    }

    /**
     * Helper function that performs DFS (Depth-First Search) on the tree.
     * It returns an int array of two values:
     *   [0] -> 1 if the subtree is balanced, 0 if not
     *   [1] -> the height of the subtree
     */
    private int[] Dfs(TreeNode root) {
        // Base case: If the current node is null (empty tree), it's balanced with height 0
        if (root == null) {
            return new int[] { 1, 0 };  // [isBalanced = 1 (true), height = 0]
        }

        // Recursively check the left and right subtrees
        int[] left = Dfs(root.left);   // Get [isBalanced, height] for left subtree
        int[] right = Dfs(root.right); // Get [isBalanced, height] for right subtree

        // Check if current subtree is balanced:
        // 1. Both left and right subtrees must be balanced
        // 2. The height difference between left and right must be <= 1
        bool balanced = (left[0] == 1 && right[0] == 1) &&
                        (Math.Abs(left[1] - right[1]) <= 1);

        // Compute the height of the current subtree
        int height = 1 + Math.Max(left[1], right[1]);

        // Return the result:
        // [0] -> 1 if balanced, else 0
        // [1] -> height of this subtree
        return new int[] { balanced ? 1 : 0, height };
    }
}
        


