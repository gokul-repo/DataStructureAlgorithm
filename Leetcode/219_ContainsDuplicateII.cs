using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //219. Contains Duplicate II
    //https://leetcode.com/problems/contains-duplicate-ii/
    public class ContainsDuplicateII
    {
        //Time - O(n)
        //Space - O(n)
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int val = nums[i];
                if (myDict.ContainsKey(val))
                {
                    if (Math.Abs(myDict[val] - i) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        myDict[val] = i;
                    }
                }
                else
                {
                    myDict.Add(val, i);
                }
            }
            return false;

        }

    }
}