namespace DataStructureAlgorithm.Leetcode
{
    //21. Merge Two Sorted Lists
    //https://leetcode.com/problems/merge-two-sorted-lists/
    public class MergeTwoSortedLists
    {
        //Time O(m+n)
        //Space O(1)
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode result = null;
            ListNode l1p1 = l1;
            ListNode l2p2 = l2;
            if (l1.val < l2.val)
            {
                result = l1p1;
                l1p1 = l1p1.next;
            }
            else
            {
                result = l2p2;
                l2p2 = l2p2.next;
            }
            ListNode p = result;
            while (l1p1 != null && l2p2 != null)
            {
                if (l1p1.val < l2p2.val)
                {
                    p.next = l1p1;
                    l1p1 = l1p1.next;
                }
                else
                {
                    p.next = l2p2;
                    l2p2 = l2p2.next;
                }
                p = p.next;
            }
            p.next = l1p1 == null ? l2p2 : l1p1;
            return result;

        }

        //Recursion
        public ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val <= l2.val)
            {
                l1.next = MergeTwoLists1(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists1(l1, l2.next);
                return l2;
            }
        }

        //Iteration - clean code
        public ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            var prev = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }
            prev.next = l1 == null ? l2 : l1;
            return dummy.next;

        }


    }
}