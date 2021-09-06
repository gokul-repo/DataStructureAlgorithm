using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //658. Find K Closest Elements
    //https://leetcode.com/problems/find-k-closest-elements/

    public class FindKClosestElements
    {
        public void main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int k = 4;
            int x = 3;
            var op = FindClosestElements(arr, k, x);
        }

        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            List<int> output = new List<int>();
            foreach (var item in arr)
            {
                output.Add(item);
            }
            output.Sort((a, b) => Math.Abs(a - x).CompareTo(Math.Abs(b - x)));
            output = output.GetRange(0, k);
            output.Sort();
            return output;
        }

        //Binary Search
        public IList<int> FindClosestElementsBinarySearch(int[] arr, int k, int x)
        {
            List<int> result = new List<int>();
            if (k == arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    result.Add(arr[i]);
                }
                return result;
            }

            int l = 0;
            int r = arr.Length;
            int index = 0;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (x > arr[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }
            l = l - 1;
            r = l + 1;
            while (k > 0)
            {
                if (l < 0)
                {
                    r++;
                    k--;
                    continue;
                }
                if (r == arr.Length || Math.Abs(arr[l] - x) <= Math.Abs(arr[r] - x))
                {
                    l--;
                }
                else
                {
                    r++;
                }
                k--;
            }

            for (int j = l + 1; j < r; j++)
            {
                result.Add(arr[j]);
            }
            return result;
        }
    }
}