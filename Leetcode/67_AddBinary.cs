using System;
using System.Text;

namespace DataStructureAlgorithm.Leetcode
{
    //67. Add Binary
    //https://leetcode.com/problems/add-binary/
    public class AddBinary
    {
        //Time - O(max(m,n))
        //Space - O(max(m,n))
        public string AddBinary1(string a, string b)
        {
            int m = a.Length;
            int n = b.Length;
            if (m < n)
            {
                return AddBinary1(b, a);
            }
            int maxLen = Math.Max(m, n);
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            int j = n - 1;
            for (int i = maxLen - 1; i > -1; i--)
            {
                if (a[i] == '1')
                {
                    carry++;
                }
                if (j > -1 && b[j] == '1')
                {
                    carry++;
                }
                j--;
                if (carry % 2 == 1)
                {
                    sb.Append("1");
                }
                else
                {
                    sb.Append("0");
                }
                carry = carry / 2;
            }
            if (carry == 1)
            {
                sb.Append("1");
            }
            char[] charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}