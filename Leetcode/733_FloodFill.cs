using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //733. Flood Fill
    //https://leetcode.com/problems/flood-fill/
    public class FloodFill
    {
        public int[][] FloodFillDFS(int[][] image, int sr, int sc, int newColor)
        {
            int color = image[sr][sc];
            if (color != newColor)
            {
                dfs(image, sr, sc, color, newColor);
            }
            return image;
        }

        public void dfs(int[][] image, int sr, int sc, int color, int newColor)
        {
            if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[0].Length || image[sr][sc] != color)
            {
                return;
            }
            image[sr][sc] = newColor;
            dfs(image, sr + 1, sc, color, newColor);
            dfs(image, sr - 1, sc, color, newColor);
            dfs(image, sr, sc + 1, color, newColor);
            dfs(image, sr, sc - 1, color, newColor);
        }
        public int[][] FloodFillBFS(int[][] image, int sr, int sc, int newColor)
        {
            Queue<int[]> myQueue = new Queue<int[]>();
            int m = image.Length;
            int n = image[0].Length;
            int color = image[sr][sc];
            List<int[]> directions = new List<int[]>(){
            new int[] {1,0},
              new int[] {-1,0},
              new int[] {0,1},
              new int[] {0,-1}
        };
            if (color != newColor)
            {
                myQueue.Enqueue(new int[] { sr, sc });
            }
            while (myQueue.Count != 0)
            {
                int[] pos = myQueue.Dequeue();
                int row = pos[0];
                int col = pos[1];
                image[row][col] = newColor;
                foreach (var dir in directions)
                {
                    int r = row + dir[0];
                    int c = col + dir[1];
                    if (r < 0 || c < 0 || r >= m || c >= n || image[r][c] != color)
                    {
                        continue;
                    }
                    image[r][c] = newColor;
                    myQueue.Enqueue(new int[] { r, c });
                }
            }
            return image;

        }
    }
}