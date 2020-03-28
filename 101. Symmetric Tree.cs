/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 //Approach 1: Recursive
public class Solution {
    public bool IsSymmetric(TreeNode root) {
     return isMirror(root,root);   
    }
    public bool isMirror(TreeNode r1,TreeNode r2) {
        if(r1==null && r2==null) {return true;}
        if(r1==null || r2==null) {return false;}
        return (r1.val==r2.val)&&(isMirror(r1.left,r2.right))&&(isMirror(r1.right,r2.left));
    }
}