using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //1. Two Sum
    //https://leetcode.com/problems/two-sum/
    public class TwoSum
    {
        //Brute Force
        // Time - O(n^2)
        // Space - O(1)
        public int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        //Two Pass using hash set
        //Time - O(n)
        //Space - O(n)
        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!myDict.ContainsKey(nums[i]))
                {
                    myDict.Add(nums[i], i);
                }
            }
            for (int j = 0; j < nums.Length; j++)
            {
                int needed = target - nums[j];
                if (myDict.ContainsKey(needed) && myDict[needed] != j)
                {
                    return new int[] { j, myDict[needed] };
                }
            }
            return null;
        }

        //One pass - using hashset
        //Time -O(n)
        //Space - O(n)
        public int[] TwoSum3(int[] nums, int target)
        {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int j = 0; j < nums.Length; j++)
            {
                int needed = target - nums[j];
                if (myDict.ContainsKey(needed))
                {
                    return new int[] { j, myDict[needed] };
                }
                if (!myDict.ContainsKey(nums[j]))
                {
                    myDict.Add(nums[j], j);
                }
            }
            return null;
        }

    }
}