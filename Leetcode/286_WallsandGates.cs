using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //286. Walls and Gates
    //https://leetcode.com/problems/walls-and-gates/

    //BRUTE FORCE APPROACH
    // Time is O(m^2 * n^2)
    //Space is O(mn)
    public class WallsandGates
    {
        public int WALL = -1;
        public int GATE = 0;
        public int EMPTY = int.MaxValue;
        public List<int[]> DIRECTIONS = new List<int[]>(){
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
        public void WallsAndGates(int[][] rooms)
        {
            if (rooms.Length == 0)
            {
                return;
            }
            for (int row = 0; row < rooms.Length; row++)
            {
                for (int col = 0; col < rooms[0].Length; col++)
                {
                    if (rooms[row][col] == EMPTY)
                    {
                        rooms[row][col] = distanceToGate(rooms, row, col);
                    }
                }
            }
        }

        public int distanceToGate(int[][] rooms, int strtRow, int strtCol)
        {
            Queue<int[]> myQueue = new Queue<int[]>();
            myQueue.Enqueue(new int[] { strtRow, strtCol });
            int m = rooms.Length;
            int n = rooms[0].Length;
            int[,] distance = new int[m, n];

            while (myQueue.Count != 0)
            {

                int[] pos = myQueue.Dequeue();
                int row = pos[0];
                int col = pos[1];
                foreach (var direction in DIRECTIONS)
                {
                    int r = row + direction[0];
                    int c = col + direction[1];
                    if (r < 0 || r >= m || c < 0 || c >= n || rooms[r][c] == WALL || distance[r, c] != 0)
                    {
                        continue;
                    }
                    distance[r, c] = distance[row, col] + 1;
                    if (rooms[r][c] == GATE)
                    {
                        return distance[r, c];
                    }
                    myQueue.Enqueue(new int[] { r, c });

                }
            }
            return int.MaxValue;
        }
    }

    // BFS
    // Time is O(mn)
    // Space is O(mn)
    public class Solution
    {
        public int WALL = -1;
        public int GATE = 0;
        public int EMPTY = int.MaxValue;
        public List<int[]> DIRECTIONS = new List<int[]>(){
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
        public void WallsAndGates(int[][] rooms)
        {
            int m = rooms.Length;
            int n = rooms[0].Length;
            if (m == 0)
            {
                return;
            }
            Queue<int[]> myQueue = new Queue<int[]>();
            for (int row = 0; row < rooms.Length; row++)
            {
                for (int col = 0; col < rooms[0].Length; col++)
                {
                    if (rooms[row][col] == GATE)
                    {
                        myQueue.Enqueue(new int[] { row, col });
                    }
                }
            }
            while (myQueue.Count != 0)
            {
                int[] position = myQueue.Dequeue();
                int cRow = position[0];
                int cCol = position[1];
                foreach (var direction in DIRECTIONS)
                {
                    int r = cRow + direction[0];
                    int c = cCol + direction[1];
                    if (r < 0 || c < 0 || r >= m || c >= n || rooms[r][c] != EMPTY)
                    {
                        continue;
                    }
                    rooms[r][c] = rooms[cRow][cCol] + 1;
                    myQueue.Enqueue(new int[] { r, c });
                }
            }
        }
    }
}