using System;

namespace DataStructureAlgorithm.Leetcode
{
    //1051. Height Checker
    //https://leetcode.com/problems/height-checker/
    public class HeightChecker
    {
        public int HeightChecker1(int[] heights)
        {
            int n = heights.Length;
            int[] newHeights = new int[n];
            for (int i = 0; i < n; i++)
            {
                newHeights[i] = heights[i];
            }
            Array.Sort(newHeights);
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (heights[j] != newHeights[j])
                {
                    count++;
                }
            }
            return count;
        }

    }
}