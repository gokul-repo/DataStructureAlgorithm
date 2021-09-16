using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //136. Single Number
    //https://leetcode.com/problems/single-number/
    public class SingleNumber
    {
        //Using HashSet
        //Time - O(n)
        //Space - O(n)
        public int SingleNumber1(int[] nums)
        {
            HashSet<int> myHashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (myHashSet.Contains(nums[i]))
                {
                    myHashSet.Remove(nums[i]);
                }
                else
                {
                    myHashSet.Add(nums[i]);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (myHashSet.Contains(nums[i]))
                {
                    return nums[i];
                }
            }
            return -1;
        }
    }
}