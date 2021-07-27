namespace DataStructureAlgorithm.Leetcode
{
    //2. Add Two Numbers
    //https://leetcode.com/problems/add-two-numbers/
    public class AddTwoNumbers
    {
        //Time - O(max(m,n))
        //Space - O(max(m,n))
        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode result = new ListNode(-1);
            var curr = result;
            while (l1 != null || l2 != null)
            {
                int l1val = l1 != null ? l1.val : 0;
                int l2val = l2 != null ? l2.val : 0;
                int sum = l1val + l2val + carry;
                int resultval = sum % 10;
                int resultCarry = sum / 10;
                ListNode newNode = new ListNode(resultval);
                curr.next = newNode;
                carry = resultCarry;
                curr = curr.next;
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
            if (carry != 0)
            {
                ListNode newNode = new ListNode(carry);
                curr.next = newNode;
            }
            return result.next;
        }

    }
}