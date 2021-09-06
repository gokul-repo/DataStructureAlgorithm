using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //119. Pascal's Triangle II
    //https://leetcode.com/problems/pascals-triangle-ii/
    public class PascalsTriangleII
    {
        //Approach from 119 solution
        public IList<int> GetRow1(int rowIndex)
        {
            List<IList<int>> triangle = new List<IList<int>>();
            List<int> firstRow = new List<int>();
            firstRow.Add(1);
            triangle.Add(firstRow);

            for (int i = 1; i <= rowIndex; i++)
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
            return triangle[rowIndex];
        }

        //Recursion
        //Time Complexity - O(2^k)
        //Space - O(k)
        public IList<int> GetRow2(int rowIndex)
        {
            List<int> output = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                output.Add(getNum(rowIndex, i));
            }
            return output;

        }

        public int getNum(int row, int col)
        {
            if (row == 0 || col == 0 || row == col)
            {
                return 1;
            }

            return getNum(row - 1, col - 1) + getNum(row - 1, col);
        }
    }
}