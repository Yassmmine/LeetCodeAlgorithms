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
     public ListNode RemoveNthFromEnd(ListNode head, int n) {
             if (head.next==null &n>0){
                 head=head.next;
                 return head;
             }
           ListNode Nodeptr=head;
           List<ListNode> nodes=new ();
           nodes.Add(Nodeptr);
        while(Nodeptr.next!=null){
             nodes.Add(Nodeptr.next);
             Nodeptr=Nodeptr.next;
        } if(nodes.Count-n-1<0){  head=head.next;
                 return head;}
        var prv=nodes[nodes.Count-n-1];
        Nodeptr=nodes[nodes.Count-n];
        prv.next=Nodeptr.next;
        return head;
    }
//     public ListNode RemoveNthFromEnd(ListNode head, int n) {
//              if (head.next==null){
//                  head=head.next;                 return head;

//              }
//         ListNode Nodeptr=head,prv=head;
//         int count=1;
//         while(Nodeptr.next!=null){
//             prv=Nodeptr;
//             Nodeptr=Nodeptr.next;
//             count++;
//         }
//         Nodeptr=head;prv=head;
//         Console.WriteLine("count={0}",count);
//         n=count-n;
//         Console.WriteLine("n={0}",n);
//         count=1;
//         if(n==0){
//                head=head.next;
//                  return head;
//         }
//          while(Nodeptr.next!=null && count<=n){
//             prv=Nodeptr;
//             Nodeptr=Nodeptr.next;
//             count++;
//         }
//         prv.next=Nodeptr.next;
//         return head;
//     }
}