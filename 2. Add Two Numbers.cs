/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(0);
        ListNode first = l1, second = l2, currentHead = dummyHead;
        int carry = 0;
        while(first!=null||second!=null) {
            int x = (first!=null)?first.val:0;
            int y = (second!=null)?second.val:0;
            int sum = x+y+carry;
            carry = sum/10;
            currentHead.next = new ListNode(sum%10);
            currentHead = currentHead.next;
            if(first!=null) {first = first.next;}
            if(second!=null) {second = second.next;}
        }
        if(carry>0) {
            currentHead.next = new ListNode(carry);
        } 
          return dummyHead.next;
    }
}