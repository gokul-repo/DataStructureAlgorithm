using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //454. 4Sum II
    //https://leetcode.com/problems/4sum-ii/
    public class FourSumII
    {
        // Hash table method
        //Time - O(n^2)
        //Space - O(n^2)
        public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            int count = 0;
            Dictionary<int, int> myDict = new Dictionary<int, int>();            
            foreach (var a in nums1)
            {
                foreach (var b in nums2)
                {
                    int sum = a + b;
                    if (myDict.ContainsKey(sum))
                    {
                        myDict[sum]++;
                    }
                    else
                    {
                        myDict.Add(sum, 1);
                    }
                }
            }
            foreach (var c in nums3)
            {
                foreach (var d in nums4)
                {
                    int complement = -(c + d);
                    if (myDict.ContainsKey(complement))
                    {
                        count += myDict[complement];
                    }
                }
            }
            return count;

        }
    }
}