using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //66. Plus One
    //https://leetcode.com/problems/plus-one/
    public class PlusOne
    {
        // Own method
        // Time - O(n)
        //Space - O(1)
        public int[] PlusOne1(int[] digits)
        {
            List<int> myList = new List<int>();
            int carry = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int digit = digits[i];
                if (i == digits.Length - 1)
                {
                    digit = digit + 1;
                }
                digit = digit + carry;
                carry = digit / 10;
                myList.Add(digit % 10);
            }
            if (carry > 0)
            {
                myList.Add(carry);
            }
            int n = myList.Count;
            int[] output = new int[n];

            foreach (var item in myList)
            {
                output[n - 1] = item;
                n--;
            }
            return output;
        }

        //Simplified
        //Time - O(n)
        //Space - O(n)
        public int[] PlusOne2(int[] digits)
        {
            List<int> myList = new List<int>();            
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
            }
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;

        }

    }
}