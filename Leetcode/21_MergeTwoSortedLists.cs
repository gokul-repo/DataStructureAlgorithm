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

    }
}