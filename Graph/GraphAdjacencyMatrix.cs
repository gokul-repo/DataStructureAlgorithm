using System;

namespace DataStructureAlgorithm.Graph
{
    //Abdul bari Implementation
    public class GraphAdjacencyMatrix
    {
        public int[,] adjMatrix = new int[7, 7];
        public int numOfNodes;

        public GraphAdjacencyMatrix(int[,] matrix, int n)
        {
            adjMatrix = matrix;
            numOfNodes = n;
        }
        public void BFS(int n)
        {
            int[] visited = new int[numOfNodes];
            System.Collections.Queue myQueue = new System.Collections.Queue();
            Console.Write(n);
            Console.Write("--->");
            visited[n] = 1;
            myQueue.Enqueue(n);
            while (myQueue.Count != 0)
            {
                int u = (int)myQueue.Dequeue();
                for (int v = 1; v < numOfNodes; v++)
                {
                    int element = adjMatrix[u, v];
                    if (visited[v] == 0 && element == 1)
                    {
                        Console.Write(v);
                        Console.Write("--->");
                        visited[v] = 1;
                        myQueue.Enqueue(v);
                    }
                }
            }
            Console.WriteLine();
        }

        //Recursion
        public void DFS(int n)
        {
            int[] visited = new int[numOfNodes];
            DFSHelper(n, visited);     
            Console.WriteLine();      
        }
        public void DFSHelper(int n, int[] visited)
        {
            if (visited[n] == 0)
            {
                Console.Write(n);
                Console.Write("--->");
                visited[n] = 1;
                for (int i = 1; i < numOfNodes; i++)
                {
                    if (visited[i] == 0 && adjMatrix[n, i] == 1)
                    {
                        DFSHelper(i,visited);
                    }
                }
            }
        }
    }
}