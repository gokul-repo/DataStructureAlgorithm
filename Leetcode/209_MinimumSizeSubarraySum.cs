using System;

namespace DataStructureAlgorithm.Leetcode
{
    //209. Minimum Size Subarray Sum
    //https://leetcode.com/problems/minimum-size-subarray-sum/

    public class MinimumSizeSubarraySum
    {
        //APproach 1 - Two pointer
        //Time - O(n)
        //Space - O(1)
        public int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int sum = 0;
            int ans = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                while (sum >= target)
                {
                    ans = Math.Min(ans, i + 1 - left);
                    sum = sum - nums[left];
                    left++;
                }
            }

            return ans == int.MaxValue ? 0 : ans;
        }

    }
}