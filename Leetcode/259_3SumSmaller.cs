using System;

namespace DataStructureAlgorithm.Leetcode
{
    //259. 3Sum Smaller
    //https://leetcode.com/problems/3sum-smaller/
    public class ThreeSumSmaller
    {
        public void main()
        {
            int[] nums = new int[] { -2, 0, 1, 3 };
            ThreeSumSmaller threesum = new ThreeSumSmaller();
            var result = threesum.twosumTest(nums, 1);
        }

        // First did Two Sum smaller for practice

        public int twosumTest(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int j = BinarySearch2Sum(i, nums, target - nums[i]);
                sum = sum + (j - i);
            }
            return sum;
        }

        public int BinarySearch2Sum(int start, int[] nums, int target)
        {
            int left = start;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (left + right + 1) / 2;
                if (nums[mid] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }

        //Binary Search Approach
        //Time - O(n^2 . log n)
        //Space - O(1)

        public int ThreeSumSmaller1(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                sum = sum + TwoSumSmaller(i + 1, nums, target - nums[i]);
            }
            return sum;
        }

        public int TwoSumSmaller(int startIdx, int[] nums, int target)
        {
            int sum = 0;
            for (int i = startIdx; i < nums.Length - 1; i++)
            {
                int j = BinarySearch(i, nums, target - nums[i]);
                sum = sum + (j - i);
            }
            return sum;
        }


        public int BinarySearch(int start, int[] nums, int target)
        {
            int left = start;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (left + right + 1) / 2;
                if (nums[mid] < target)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
        //Two Pointer
        //Time - O(n^2 . log n)
        //Space - O(1)

        public int ThreeSumSmaller2(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                sum = sum + TwoSumSmaller2(i, nums, target - nums[i]);
            }
            return sum;
        }
        public int TwoSumSmaller2(int startIdx, int[] nums, int target)
        {
            int sum=0;
            int left = startIdx;
            int right = nums.Length - 1;
            while (left < right)
            {
                if(nums[left]+nums[right] < target){
                    sum=sum+(right-left);
                    left++;
                }else{
                    right--;
                }

            }
            return sum;
        }


    }
}