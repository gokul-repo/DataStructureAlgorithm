using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //234. Palindrome Linked List
    //https://leetcode.com/problems/palindrome-linked-list/
    public class PalindromeLinkedList
    {
        //Using List
        // Time - O(n)
        //Space - O(n) - coz of list
        public bool IsPalindrome(ListNode head)
        {
            List<int> myList = new List<int>();
            ListNode curr = head;
            while (curr != null)
            {
                myList.Add(curr.val);
                curr = curr.next;
            }
            int start = 0;
            int end = myList.Count - 1;
            while (start < end)
            {
                if (myList[start] != myList[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}