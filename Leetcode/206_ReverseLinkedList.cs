using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //206. Reverse Linked List
    //https://leetcode.com/problems/reverse-linked-list/
    public class ReverseLinkedList
    {
        //Time - O(n)
        //Space - O(1)
        public ListNode ReverseListIterative(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var curr = head;
            while (curr.next != null)
            {
                var temp = curr.next;
                curr.next = temp.next;
                temp.next = head;
                head = temp;
            }
            return head;
        }
        //Recursion
         //Time - O(n)
        //Space - O(n) - coz of stack
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }            
            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;


        }

    }
}