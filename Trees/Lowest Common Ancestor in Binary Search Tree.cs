#Solution 1: 
/**
Approach to solve this problem But Binary Tree:-
1. if llca =null , rlca =null will return null to upper node.
2. if llca = valid, rlca= invalid or vice versa, return valid value.
3. when llca as well as rlca is not null return root.
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
{
    if (root == null || p == null || q == null)
        return null;

    // If the current node matches either p or q, return root
    if (root == p || root == q)
        return root;

    // Recursively search for LCA in left and right subtrees
    TreeNode leftLca = LowestCommonAncestor(root.left, p, q);
    TreeNode rightLca = LowestCommonAncestor(root.right, p, q);

    // Case 1: Both sides return a valid node => p and q found in different subtrees
    if (leftLca != null && rightLca != null)
        return root;

    // Case 2: Only one side is non-null (found LCA deeper on one side)
    if (leftLca != null)
        return leftLca;

    return rightLca;
}
}
**/
#Binary Serach Tree:-
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        TreeNode current= root;
        while(current!=null)
        {
            if(p.val > current.val && q.val > current.val)
                current = current.right;
            if(p.val < current.val && q.val < current.val)
                current = current.left;
            else
                return current;
        
        }
        return null;
    }
}


#sloution 2:
