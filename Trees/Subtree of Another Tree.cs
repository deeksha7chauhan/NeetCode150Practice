public class Solution {
    // Function to check if two trees are identical
    public bool IsIdentical(TreeNode p, TreeNode q) {
        if (p == null || q == null)
            return p == q;

        return p.val == q.val &&
               IsIdentical(p.left, q.left) &&
               IsIdentical(p.right, q.right);
    }

    // Function to check if subRoot is a subtree of root
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null || subRoot == null)
            return root == subRoot;

        if (root.val == subRoot.val && IsIdentical(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
}
//Time complexity: O(m∗n) Space complexity: O(m+n)

// 1. Check if both trees are null → return true
// 2. If one tree is null and the other isn’t → return false
// 3. If root values match, call isIdentical(root, subRoot)
// 4. If trees are identical, return true
// 5. Otherwise, recurse on root.left and root.right with subRoot
