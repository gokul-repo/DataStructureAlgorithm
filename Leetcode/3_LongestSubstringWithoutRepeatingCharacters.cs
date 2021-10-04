using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //3. Longest Substring Without Repeating Characters
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/
    public class LongestSubstringWithoutRepeatingCharacters
    {
        // Brute force
        // Time - O(n^3)
        // Space - O(k)
        public int LengthOfLongestSubstring1(string s)
        {
            int n = s.Length;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (isUnique(s, i, j))
                    {
                        res = Math.Max(res, j - i + 1);
                    }
                }
            }
            return res;
        }

        public bool isUnique(string s, int start, int end)
        {
            HashSet<char> mySet = new HashSet<char>();
            for (int i = start; i <= end; i++)
            {
                if (mySet.Contains(s[i]))
                {
                    return false;
                }
                mySet.Add(s[i]);
            }
            return true;
        }

        //using dictionary
        //Time - O(n)
        //Space - O(min(n,m))
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int ans = 0;
            Dictionary<char, int> mySet = new Dictionary<char, int>();
            for (int i = 0, j = 0; j < n; j++)
            {
                if (mySet.ContainsKey(s[j]))
                {
                    i = Math.Max(mySet[s[j]], i);
                }
                ans = Math.Max(ans, j - i + 1);
                mySet[s[j]] = j + 1;


            }
            return ans;
        }

    }
}