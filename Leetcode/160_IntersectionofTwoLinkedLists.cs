using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //160. Intersection of Two Linked Lists
    //https://leetcode.com/problems/intersection-of-two-linked-lists/

    public class IntersectionofTwoLinkedLists
    {
        //Time - O(m+n)
        //Space - O(m)
        public ListNode GetIntersectionNodeHash(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> mySet = new HashSet<ListNode>();
            ListNode curr = headA;
            while (curr != null)
            {
                mySet.Add(curr);
                curr = curr.next;
            }
            curr = headB;
            while (curr != null)
            {
                if (mySet.Contains(curr))
                {
                    return curr;
                }
                curr = curr.next;
            }
            return null;
        }
        //Time - O(m+n)
        //Space - O(1)
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int lenA = 0;
            int lenB = 0;
            ListNode curr = headA;
            while (curr != null)
            {
                lenA++;
                curr = curr.next;
            }
            curr = headB;
            while (curr != null)
            {
                lenB++;
                curr = curr.next;
            }
            ListNode first;
            ListNode second;
            if (lenA < lenB)
            {
                first = headA;
                second = headB;
                for (int i = 0; i < lenB - lenA; i++)
                {
                    second = second.next;
                }
            }
            else
            {
                first = headA;
                second = headB;
                for (int i = 0; i < lenA - lenB; i++)
                {
                    first = first.next;
                }
            }
            while (first != second)
            {
                first = first.next;
                second = second.next;
            }
            return first;

        }
    }
}