using System;

namespace DataStructureAlgorithm.Leetcode
{
    //485. Max Consecutive Ones
    //https://leetcode.com/problems/max-consecutive-ones/ 
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
            {
                return 0;
            }
            int maxCount = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    maxCount = maxCount > count ? maxCount : count;
                    count = 0;
                }
            }
            maxCount = maxCount > count ? maxCount : count;
            return maxCount;
        }
        //Sliding window approach
        public int FindMaxConsecutiveOnes_SlidingWindow(int[] nums)
        {
            int n = nums.Length;
            int maxCount = 0;
            int left = 0;
            int right = 0;
            while (left < n && right < n)
            {
                while (left < n && nums[left] == 0)
                {
                    left++;
                }
                right = left;
                while (right < n && nums[right] == 1)
                {
                    right++;
                }
                maxCount = Math.Max(maxCount, right - left);
                left = right;
            }
            return maxCount;
        }
    }
}