namespace DataStructureAlgorithm.Leetcode
{
    //24. Swap Nodes in Pairs
    //https://leetcode.com/problems/swap-nodes-in-pairs/

    public class SwapNodesinPairs
    {
        //Recursion
        //Time - O(n)
        //Space - O(n)
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            var first = head;
            var second = head.next;

            first.next = SwapPairs(second.next);
            second.next = first;
            return second;
        }

        //Iterative 
        //Time - O(n)
        //Space - O(1) - no recursive stack
        public ListNode SwapPairs1(ListNode head)
        {
            ListNode dummy = new ListNode(-1);
            dummy.next = head;
            var prev = dummy;
            while (head != null && head.next != null)
            {
                var firstNode = head;
                var secondNode = head.next;
                firstNode.next = secondNode.next;
                secondNode.next = prev.next;
                prev.next = secondNode;

                prev = firstNode;
                head = firstNode.next;
            }
            return dummy.next;

        }

    }
}