using System;

namespace DataStructureAlgorithm.Graph
{
    //Example from https://www.geeksforgeeks.org/floyd-warshall-algorithm-dp-16/
    public class FloydWarshall
    {
        public int POSITIVE_INFINITY = 99999;
        public void FloydWarshall_Main()
        {
            int numberOfVertces = 4;          

                int[,] graph = new int[,] { {0, 5, POSITIVE_INFINITY, 10},
                        {POSITIVE_INFINITY, 0, 3, POSITIVE_INFINITY},
                        {POSITIVE_INFINITY, POSITIVE_INFINITY, 0, 1},
                        {POSITIVE_INFINITY, POSITIVE_INFINITY, POSITIVE_INFINITY, 0}
                        };

            var distances = FloydWarshallASSP(graph);

            for (int i = 0; i < numberOfVertces; ++i)
            {
                for (int j = 0; j < numberOfVertces; ++j)
                {
                    if (distances[i, j] == POSITIVE_INFINITY)
                    {
                        Console.Write("INF ");
                    }
                    else
                    {
                        Console.Write(distances[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }

        public int[,] FloydWarshallASSP(int[,] graph)
        {
            int n = 4;
            int[,] distance = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distance[i, j] = graph[i, j];
                }
            }
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j])
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                        }
                    }
                }
            }
            return distance;
        }
    }
}