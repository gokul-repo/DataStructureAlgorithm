namespace DataStructureAlgorithm.Leetcode
{
    //141. Linked List Cycle
    //https://leetcode.com/problems/linked-list-cycle/
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
                fast = fast.next;
                if (slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}