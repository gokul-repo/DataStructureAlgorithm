using System;

namespace DataStructureAlgorithm.Leetcode
{
    //561. Array Partition I
    //https://leetcode.com/problems/array-partition-i/
    public class ArrayPartitionI
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum = sum + nums[i];
            }
            return sum;
        }
    }
}