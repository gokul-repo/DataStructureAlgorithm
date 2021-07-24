namespace DataStructureAlgorithm.Leetcode
{
    //328. Odd Even Linked List
    //https://leetcode.com/problems/odd-even-linked-list/
    public class OddEvenLinkedList
    {
        //Time - O(n)
        //Space - O(1)
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            ListNode oddHead = head;
            ListNode odd = head;
            ListNode evenHead = head.next;
            ListNode even = head.next;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return oddHead;
        }
    }
}