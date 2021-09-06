using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //118. Pascal's Triangle
    //https://leetcode.com/problems/pascals-triangle/
    public class PascalsTriangle
    {
        //Time Complexity - O(n^2)
        //Space Complexity - O(n^2)
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> triangle = new List<IList<int>>();
            List<int> firstRow = new List<int>();
            firstRow.Add(1);
            triangle.Add(firstRow);

            for (int i = 1; i < numRows; i++)
            {
                List<int> newRow = new List<int>();
                newRow.Add(1);
                var prevRow = triangle[i - 1];
                for (int j = 1; j < i; j++)
                {
                    int val = prevRow[j - 1] + prevRow[j];
                    newRow.Add(val);
                }
                newRow.Add(1);
                triangle.Add(newRow);
            }
            return triangle;
        }

    }
}