namespace DataStructureAlgorithm.Leetcode
{
    //344. Reverse String
    //https://leetcode.com/problems/reverse-string/
    public class ReverseString
    {
        // Approach 1 - Two pointer
        // Time - O(n)
        // Space - O(1)

        public void ReverseString1(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                char c = s[i];
                s[i] = s[j];
                s[j] = c;
                i++;
                j--;
            }
        }

        //Approach 2 - Recursion
        // Time -O(n)
        //Space - O(n) (using stack)
        public void ReverseString2(char[] s)
        {
            helper(s, 0, s.Length - 1);
        }
        public void helper(char[] s, int l, int r)
        {
            if (l >= r)
            {
                return;
            }
            char c = s[l];
            s[l] = s[r];
            s[r] = c;
            l++;
            r--;
            helper(s, l, r);
        }
    }
}