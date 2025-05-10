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
    public int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}




public class Solution {
    public int MaxDepth(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        if (root != null) {
            q.Enqueue(root);
        }

        int level = 0;
        while (q.Count > 0) {
            int size = q.Count;
            for (int i = 0; i < size; i++) {
                TreeNode node = q.Dequeue();
                if (node.left != null) {
                    q.Enqueue(node.left);
                }
                if (node.right != null) {
                    q.Enqueue(node.right);
                }
            }
            level++;
        }
        return level;
    }
}
//technique is called Breadth-First Search (BFS) or level-order traversal.
//BFS visits all nodes level by level.
//A FIFO queue perfectly models that idea—newly discovered children wait their turn behind nodes of the current level, so we never mix levels.
//The queue lets us march across the tree level-by-level, incrementing level each pass; when the queue empties, level equals the maximum depth.
//inorder DFS Time and SPace complexity = O(n). 

public class Solution {
    public int MaxDepth(TreeNode root) {
        Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
        stack.Push(new Tuple<TreeNode, int>(root, 1));
        int res = 0;

        while (stack.Count > 0) {
            Tuple<TreeNode, int> current = stack.Pop();
            TreeNode node = current.Item1;
            int depth = current.Item2;

            if (node != null) {
                res = Math.Max(res, depth);
                stack.Push(new Tuple<TreeNode, int>(node.left, depth + 1));
                stack.Push(new Tuple<TreeNode, int>(node.right, depth + 1));
            }
        }
        return res;
    }
}

//Preorder DFS easiest Time and SPace complexity = O(n)
