using System;

namespace DataStructureAlgorithm.Leetcode
{
    //16. 3Sum Closest
    //https://leetcode.com/problems/3sum-closest/
    public class ThreeSumClosest
    {
        public void main()
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            ThreeSumClosest threesum = new ThreeSumClosest();
            var result = threesum.ThreeSumClosest1(nums,3);
        }

        public int ThreeSumClosest1(int[] nums, int target)
        {
            int diff = int.MaxValue;
            int sz = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < sz && diff != 0; i++)
            {
                int lo = i + 1;
                int hi = sz - 1;
                while (lo < hi)
                {
                    int sum = nums[i] + nums[lo] + nums[hi];
                    if (Math.Abs(target - sum) < Math.Abs(diff))
                    {
                        diff = target - sum;
                    }
                    if (sum < target)
                    {
                        ++lo;
                    }
                    else
                    {
                        --hi;
                    }
                }
            }
            return target - diff;
        }

    }
}