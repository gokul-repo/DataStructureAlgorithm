using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //542. 01 Matrix
    //https://leetcode.com/problems/01-matrix/

    //Time complexity - O(m*n)
    //Space Complexity - O(m*n)
    public class ZeroOneMatrix
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            int m = mat.Length;
            if (m == 0)
            {
                return mat;
            }
            int n = mat[0].Length;
            Queue<int[]> myQueue = new Queue<int[]>();
            bool[,] visited = new bool[m, n];
            List<int[]> directions = new List<int[]>{
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1}
        };
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        visited[i, j] = true;
                        myQueue.Enqueue(new int[] { i, j });
                    }
                }
            }

            while (myQueue.Count != 0)
            {
                int[] pos = myQueue.Dequeue();
                int row = pos[0];
                int col = pos[1];
                foreach (var dir in directions)
                {
                    int r = row + dir[0];
                    int c = col + dir[1];
                    if (r < 0 || r >= m || c < 0 || c >= n || visited[r, c])
                    {
                        continue;
                    }
                    mat[r][c] = mat[row][col] + 1;
                    visited[r, c] = true;
                    myQueue.Enqueue(new int[] { r, c });
                }
            }
            return mat;
        }

    }
}