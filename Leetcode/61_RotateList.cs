namespace DataStructureAlgorithm.Leetcode
{
    //61. Rotate List
    //https://leetcode.com/problems/rotate-list/
    public class RotateList
    {
        //Time exceeded solution for great input values
        // Time - O(n * k) when k gets high time exceeds
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head;
            }
            while (k > 0)
            {
                ListNode temp = head;
                ListNode prev = null;
                ListNode curr = head;
                while (curr.next != null)
                {
                    prev = curr;
                    curr = curr.next;
                }
                curr.next = head;
                prev.next = null;
                head = curr;
                k--;
            }
            return head;
        }
        //Correct solution
        //TIme - O(n)
        //Space - O(1)
        public ListNode RotateRight1(ListNode head, int k) {
        if(head==null){
            return null;
        }
        if(head.next==null){
            return head;
        }
        ListNode oldTail = head;
        int n;
        for(n=1;oldTail.next!=null;n++){
            oldTail=oldTail.next;
        }
        oldTail.next=head;
        ListNode newTail=head;
        for(int i=0;i<n-(k%n)-1;i++){
            newTail=newTail.next;
        }
        head=newTail.next;
        newTail.next=null;
        return head;
    }

    }
}