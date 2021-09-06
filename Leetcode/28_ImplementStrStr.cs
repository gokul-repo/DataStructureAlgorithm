using System;

namespace DataStructureAlgorithm.Leetcode
{
    //28. Implement strStr()
    //https://leetcode.com/problems/implement-strstr/
    public class ImplementStrStr
    {
        public void Main(){
            string a = "mississippi";
            string b = "mississippi";
            Console.WriteLine(StrStr(a,b));
        }
        public int StrStr(string haystack, string needle)
        {
            int m = haystack.Length;
            int n = needle.Length;
            if (n == 0)
            {
                return 0;
            }
            if (m == 0)
            {
                return -1;
            }

            for (int i = 0; i < m + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (j == n)
                    {
                        return i;
                    }
                    if (i + j == m)
                    {
                        return -1;
                    }
                    if (haystack[j] != needle[i + j])
                    {
                        break;
                    }
                }
            }
            return -1;
        }
    }
}