using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //217. Contains Duplicate
    //https://leetcode.com/problems/contains-duplicate/
    public class ContainsDuplicate
    {
        //Time -O(n)
        //Space - O(n)
        public bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> myHashSet = new HashSet<int>();            
            for (int i = 0; i < nums.Length; i++)
            {
                if (myHashSet.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    myHashSet.Add(nums[i]);
                }
            }
            return false;
        }

    }
}