using System;

namespace DataStructureAlgorithm.Graph
{
    public class GraphAdjacencyMatrixMain
    {
        //1. BFS - Adj. Matrix
        //2. BFS - Adj. List
        //3. DFS - Adj. Matrix
        //4. DFS - Adj. List

        static void main(string[] args)
        {
            int[,] graph = new int[7, 7]{{0,0,0,0,0,0,0},
                                        {0,0,1,1,0,0,0},
                                        {0,1,0,0,1,0,0},
                                        {0,1,0,0,1,0,0},
                                        {0,0,1,1,0,1,1},
                                        {0,0,0,0,1,0,0},
                                        {0,0,0,0,1,0,0}};
            GraphAdjacencyMatrix myGraph = new GraphAdjacencyMatrix(graph,7);
            Console.WriteLine("==========BFS===========");
            myGraph.BFS(1);
            myGraph.BFS(2);
            myGraph.BFS(5);
            myGraph.BFS(4);
            Console.WriteLine("==========DFS===========");
            myGraph.DFS(1);
            myGraph.DFS(4);
            myGraph.DFS(5);



        }
    }
}