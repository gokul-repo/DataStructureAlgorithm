using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //350. Intersection of Two Arrays II
    //https://leetcode.com/problems/intersection-of-two-arrays-ii/
    public class IntersectionofTwoArraysII
    {
        // Time - O(n+m)
        // Space - O(min(n,m))
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return Intersect(nums2, nums1);
            }
            List<int> output = new List<int>();
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                int val = nums1[i];
                if (myDict.ContainsKey(val))
                {
                    myDict[val] = myDict[val] + 1;
                }
                else
                {
                    myDict.Add(val, 1);
                }
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                int val1 = nums2[j];
                if (myDict.ContainsKey(val1) && myDict[val1] > 0)
                {
                    output.Add(val1);
                    myDict[val1] = myDict[val1] - 1;
                }
            }
            return output.ToArray();
        }
    }
}