/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode res = (l1.val<l2.val)?l1:l2;
        while(l1.next!=null||l2.next!=null) {
            
        }
    }
}