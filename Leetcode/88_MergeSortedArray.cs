using System;

namespace DataStructureAlgorithm.Leetcode
{
    //88. Merge Sorted Array
    //https://leetcode.com/problems/merge-sorted-array/

    // Simillar questions
    // Merge Two Sorted Lists
    // Squares of a Sorted Array
    // Interval List Intersections

    public class MergeSortedArray
    {
        static void main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 4, 5, 6, 0 };
            int m = 5;
            int[] nums2 = new int[] { 3 };
            int n = 1;
            MergeSortedArray msa = new MergeSortedArray();
            msa.Merge_Sort(nums1, m, nums2, n);
            Utilities.Utilities.PrintArray(nums1);
        }

        //Using in-built sort
        //Time complexity is O((m+n)log(m+n))  -- Coz of sort which takes nlogn
        public void Merge_Sort(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }

        //Using three pointer start from the beginning
        // Time complexity - O(m+n)
        //Space Complexity - O(m) ( W e are using extra space. We can eliminate extra space in next method)
        public void Merge_Start(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums1Copy = new int[m];
            for (int s = 0; s < m; s++)
            {
                nums1Copy[s] = nums1[s];
            }
            int i = 0;
            int j = 0;
            int k = 0;
            while (k < m + n)
            {
                if (j >= n || (i < m && nums1Copy[i] < nums2[j]))
                {
                    nums1[k] = nums1Copy[i];
                    i++;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j++;
                }
                k++;
            }
        }

        //Using three pointer start from the End
        // Time complexity - O(m+n)
        //Space Complexity - O(1) ( W e are NOT using extra space.)
        public void Merge_End(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (k >= 0)
            {
                if (j < 0)
                {
                    break;
                }
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                    k--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                    k--;
                }
            }
        }
    }
}