using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //18. 4Sum
    //https://leetcode.com/problems/4sum/
    public class FourSum
    {


        public void main()
        {
            int[] nums = new int[] { 2,2,2,2};
            FourSum foursum = new FourSum();
            var result = foursum.FourSum1(nums,8);
        }
        public IList<IList<int>> FourSum1(int[] nums, int target)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    ThreeSum(i, nums, target - nums[i], result);
                }
            }
            return result;
        }

        public void ThreeSum(int i, int[] nums, int target, List<IList<int>> result)
        {
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i+1 && nums[j] == nums[j - 1])
                {
                    continue;
                }               
                TwoSum(i, j, nums, target - nums[j], result);
            }
        }

        public void TwoSum(int i, int j, int[] nums, int target, List<IList<int>> result)
        {
            int start = j + 1;
            int end = nums.Length - 1;
            while (start < end)
            {
                int sum = nums[start] + nums[end];
                if (sum < target)
                {
                    start++;
                }
                else if (sum > target)
                {
                    end--;
                }
                else
                {
                    List<int> myList = new List<int> { nums[i], nums[j], nums[start], nums[end] };
                    result.Add(myList);
                    start++;
                    end--;
                    while (start < end && nums[start] == nums[start - 1])
                    {
                        start++;
                    }
                    while (start < end && nums[end] == nums[end + 1])
                    {
                        end--;
                    }
                }
            }

        }

    }
}