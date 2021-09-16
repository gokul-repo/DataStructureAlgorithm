using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //349. Intersection of Two Arrays
    //https://leetcode.com/problems/intersection-of-two-arrays/
    public class IntersectionofTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> myHashSet = new HashSet<int>();
            List<int> output = new List<int>();            
            for (int i = 0; i < nums1.Length; i++)
            {
                myHashSet.Add(nums1[i]);
            }
            for (int j = 0; j < nums2.Length; j++)
            {
                if (myHashSet.Contains(nums2[j]))
                {
                    output.Add(nums2[j]);
                    myHashSet.Remove(nums2[j]);
                }
            }
            return output.ToArray();
        }

    }
}