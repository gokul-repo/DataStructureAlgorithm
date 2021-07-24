using System;

namespace DataStructureAlgorithm.Leetcode
{
    //1299. Replace Elements with Greatest Element on Right Side
    //https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/

    public class ReplaceElementsGreatestRightSide
    {
        //O(n^2)
        public int[] ReplaceElements(int[] arr)
        {
            int n = arr.Length;
            if (n == 1)
            {
                arr[0] = -1;
                return arr;
            }
            for (int i = 0; i < n; i++)
            {
                int greatest = 0;
                for (int j = i + 1; j < n; j++)
                {
                    greatest = greatest > arr[j] ? greatest : arr[j];
                }
                arr[i] = greatest;
            }
            arr[n - 1] = -1;

            return arr;
        }

        //O(n)
        public int[] ReplaceElements_Linear(int[] arr)
        {
            int n = arr.Length;
            int max = -1;
            int temp = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                temp = arr[i];
                arr[i] = max;
                max = Math.Max(max, temp);
            }
            return arr;
        }

    }
}