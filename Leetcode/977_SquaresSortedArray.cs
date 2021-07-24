using System;

namespace DataStructureAlgorithm.Leetcode
{
    //977. Squares of a Sorted Array
    //https://leetcode.com/problems/squares-of-a-sorted-array/

    public class SquaresSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);
            return nums;
        }

        public int[] SortedSquares_TwoPointer(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int left = 0;
            int right = n - 1;
            for (int i = right; i >= 0; i--)
            {
                int square;
                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    square = nums[right];
                    right--;
                }
                else
                {
                    square = nums[left];
                    left++;
                }
                result[i] = square * square;
            }
            return result;
        }
    }
}