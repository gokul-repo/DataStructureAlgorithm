namespace DataStructureAlgorithm.Leetcode
{
    //203. Remove Linked List Elements
    //https://leetcode.com/problems/remove-linked-list-elements/
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }
            ListNode Sentinal = new ListNode(0);
            Sentinal.next = head;
            ListNode prev = Sentinal;
            ListNode curr = head;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    prev.next = curr.next;
                    curr = curr.next;
                    continue;
                }
                prev = curr;
                curr = curr.next;
            }
            return Sentinal.next;
        }

    }
}