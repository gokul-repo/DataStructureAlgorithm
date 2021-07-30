using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //200. Number of Islands
    //https://leetcode.com/problems/number-of-islands/

    //DFS Solution
    //Time - O(m X n)
    //Space - O(m X n) - in worst case the dfs goes m X n deep in recursion stack;
    public class NumberofIslandsDFS
    {
        public int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            if (m == 0)
            {
                return 0;
            }
            int IslandCount = 0;
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        IslandCount++;
                        dfs(grid, row, col);
                    }
                }
            }
            return IslandCount;
        }
        public void dfs(char[][] grid, int row, int col)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            if (row < 0 || col < 0 || row >= m || col >= n || grid[row][col] == '0')
            {
                return;
            }
            grid[row][col] = '0';
            dfs(grid, row + 1, col);
            dfs(grid, row - 1, col);
            dfs(grid, row, col + 1);
            dfs(grid, row, col - 1);
        }
    }

    // BFS
    // Time - O(m X n)
    // Space - O(min(m ,n))  -- This is because at a given time the queue will only hold min of m,n in a iteration
    public class NumberofIslandsBFS
    {
        public int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            if (m == 0)
            {
                return 0;
            }
            int IslandCount = 0;
            List<int[]> directions = new List<int[]>(){
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1}
        };
            Queue<int[]> myQueue = new Queue<int[]>();
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        IslandCount++;
                        myQueue.Enqueue(new int[] { row, col });
                        while (myQueue.Count != 0)
                        {
                            int[] position = myQueue.Dequeue();
                            int cRow = position[0];
                            int cCol = position[1];
                            foreach (var direction in directions)
                            {
                                int r = cRow + direction[0];
                                int c = cCol + direction[1];
                                if (r < 0 || c < 0 || r >= m || c >= n || grid[r][c] == '0')
                                {
                                    continue;
                                }
                                grid[r][c] = '0';
                                myQueue.Enqueue(new int[] { r, c });
                            }
                        }
                    }
                }
            }
            return IslandCount;
        }

    }
}