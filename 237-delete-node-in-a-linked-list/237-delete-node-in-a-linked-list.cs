/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
// [4,5,1,9]
// 5
public class Solution {
    public void DeleteNode(ListNode node) {
        //var prv=node.next;  //4
        //if(n)
        var cpNode=node.next;
        node.val=node.next.val;//12445 //prv
        node.next=node.next;//12445 //prv
        var current=node.next;  //4
        node.next=current.next;
    }
}