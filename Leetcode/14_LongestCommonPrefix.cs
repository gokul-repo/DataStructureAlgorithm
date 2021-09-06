using System;

namespace DataStructureAlgorithm.Leetcode
{
    //14. Longest Common Prefix
    //https://leetcode.com/problems/longest-common-prefix/
    public class LongestCommonPrefix
    {
        //Approach 1 - Horizontal scaning
        //Time complexity : O(S)O(S) , where S is the sum of all characters in all strings.
        // Space - O(1)
        public string LongestCommonPrefix1(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0)
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }

        //Approach 2 - Vertical scaning
        public string LongestCommonPrefix2(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || c != strs[j][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }

        //Approach 3 - Divide and conquer
        public string LongestCommonPrefix3(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            return lcp(strs, 0, strs.Length - 1);
        }
        public string lcp(string[] strs, int l, int r)
        {
            if (l == r)
            {
                return strs[l];
            }
            int mid = l + (r - l) / 2;
            string left = lcp(strs, l, mid);
            string right = lcp(strs, mid + 1, r);
            return common(left, right);
        }
        public string common(string left, string right)
        {
            int min = Math.Min(left.Length, right.Length);
            for (int i = 0; i < min; i++)
            {
                if (left[i] != right[i])
                {
                    return left.Substring(0, i);
                }
            }
            return left.Substring(0, min);
        }

        // APproach 4 - Binary searcg

        public string LongestCommonPrefix4(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            int minLen = int.MaxValue;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < minLen)
                {
                    minLen = strs[i].Length;
                }
            }
            int left = 0;
            int right = minLen;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (common(strs, mid))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return strs[0].Substring(0, (left + right) / 2);
        }
        public bool common(string[] strs, int len)
        {
            string prefix = strs[0].Substring(0, len);
            for (int i = 1; i < strs.Length; i++)
            {
                if (!strs[i].StartsWith(prefix))
                {
                    return false;
                }
            }
            return true;
        }

    }
}