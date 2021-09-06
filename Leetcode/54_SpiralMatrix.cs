using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //54. Spiral Matrix
    //https://leetcode.com/problems/spiral-matrix/
    public class SpiralMatrix
    {
        //Method 1 - using boundaries
        //Time - O(M.N)
        //Space - O(1)
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            List<int> result = new List<int>();
            int total = row * col;
            int up = 0;
            int left = 0;
            int right = col - 1;
            int down = row - 1;
            while (result.Count < total)
            {
                for (int c = left; c <= right; c++)
                {
                    result.Add(matrix[up][c]);
                }
                for (int r = up + 1; r <= down; r++)
                {
                    result.Add(matrix[r][right]);
                }
                if (up != down)
                {
                    for (int c1 = right - 1; c1 >= left; c1--)
                    {
                        result.Add(matrix[down][c1]);
                    }
                }
                if (left != right)
                {
                    for (int r1 = down - 1; r1 > up; r1--)
                    {
                        result.Add(matrix[r1][left]);
                    }
                }
                left++;
                right--;
                up++;
                down--;

            }
            return result;


        }

    }
}