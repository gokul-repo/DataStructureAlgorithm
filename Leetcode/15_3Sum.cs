using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //15. 3Sum
    //https://leetcode.com/problems/3sum/
    public class ThreeSum
    {

        public void main()
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            ThreeSum threesum = new ThreeSum();
            var result = threesum.ThreeSum2(nums);
        }

        //Using Two Sum II approach
        //Time - O(n^2)
        //Space -O(logn) to  O(n)
        public IList<IList<int>> ThreeSum1(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    twoSumII(i, nums, result);
                }
            }
            return result;
        }

        void twoSumII(int i, int[] nums, List<IList<int>> result)
        {
            int start = i + 1;
            int end = nums.Length - 1;
            while (start < end)
            {
                int sum = nums[start] + nums[end] + nums[i];
                if (sum < 0)
                {
                    start++;
                }
                else if (sum > 0)
                {
                    end--;
                }
                else
                {
                    List<int> triplet = new List<int> { nums[i], nums[start], nums[end] };
                    result.Add(triplet);
                    start++;
                    end--;
                    while (start < end && nums[start] == nums[start - 1])
                        start++;
                    while (start < end && nums[end] == nums[end + 1])
                        end--;
                }
            }
        }

        //Using Two Sum II approach
        //Time - O(n^2)
        //Space -O(logn) to  O(n)

        public IList<IList<int>> ThreeSum2(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    break;
                }
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    twoSumI(i, nums, result);
                }
            }
            return result;
        }

        void twoSumI(int i, int[] nums, List<IList<int>> result)
        {
            HashSet<int> mySet = new HashSet<int>();
            for (int j = i + 1; j < nums.Length; j++)
            {
                int complement = -nums[i] - nums[j];
                if (mySet.Contains(complement))
                {
                    List<int> triplet = new List<int> { nums[i], nums[j], complement };
                    result.Add(triplet);
                    while (j + 1 < nums.Length && nums[j] == nums[j + 1])
                    {
                        j++;
                    }
                }
                mySet.Add(nums[j]);
            }
        }

    }
}