/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
     public ListNode MiddleNode(ListNode head) 
    {
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    // public ListNode MiddleNode(ListNode head) {
    //     var Nodeptr=head;
    //     int count=1;
    //     while(Nodeptr.next!=null){
    //         Nodeptr=Nodeptr.next;
    //         count++;
    //     }
    //     Console.WriteLine("count={0}",count);
    //     int requiedN=count%2==0?(count/2)+1:(count+1)/2;
    //         Console.WriteLine("r={0}",requiedN);
    //     ListNode midle=head;
    //     count=1;
    //     Nodeptr=head;
    //      while(Nodeptr.next!=null && count<requiedN){
    //         Nodeptr=Nodeptr.next;
    //          midle=Nodeptr;
    //         count++;
    //     }
    //     return midle;
    // }
}