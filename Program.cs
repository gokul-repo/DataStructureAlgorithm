using System;
using DataStructureAlgorithm.Graph;
using DataStructureAlgorithm.Hashing;


namespace DataStructureAlgorithm
{
    internal class Program
    {
        //1. BFS - Adj. Matrix
        //2. BFS - Adj. List
        //3. DFS - Adj. Matrix
        //4. DFS - Adj. List

        static void Main(string[] args)
        {


            #region DFS - William Fiset



            // Create a fully connected graph
            //           (0)
            //           / \
            //        5 /   \ 4
            //         /     \
            // 10     <   -2  >
            //   +->(2)<------(1)      (4)
            //   +--- \       /
            //         \     /
            //        1 \   / 6
            //           > <
            //           (3)

            GraphDS mygraph = new GraphDS();
            mygraph.AddDirectedEdge(0, 1, 4);
            mygraph.AddDirectedEdge(0, 2, 5);
            mygraph.AddDirectedEdge(1, 2, -2);
            mygraph.AddDirectedEdge(1, 3, 6);
            mygraph.AddDirectedEdge(2, 3, 1);
            mygraph.AddDirectedEdge(2, 2, 10);

            int numberOfNodes = 5;
            Console.WriteLine("---------------DFS Recursive-----------------");
            int nodeCount = mygraph.DFSRecursive(0, new bool[numberOfNodes]);
            Console.WriteLine("\n DFS node count starting at node 0: " + nodeCount);
            if (nodeCount != 4)
                Console.WriteLine("\n Error with DFS");
            nodeCount = mygraph.DFSRecursive(4, new bool[numberOfNodes]);
            Console.WriteLine("\n DFS node count starting at node 4: " + nodeCount);
            if (nodeCount != 1)
                Console.WriteLine("\n Error with DFS");

            Console.WriteLine("\n \n---------------DFS Iterative-----------------");
            nodeCount = mygraph.DFSIterative(0, new bool[numberOfNodes]);
            Console.WriteLine("\n DFS node count starting at node 0: " + nodeCount);
            if (nodeCount != 4)
                Console.WriteLine("\n Error with DFS");
            nodeCount = mygraph.DFSIterative(4, new bool[numberOfNodes]);
            Console.WriteLine("\n DFS node count starting at node 4: " + nodeCount);
            if (nodeCount != 1)
                Console.WriteLine("\n Error with DFS");

            #endregion

            #region BFS - William Fiset           

            GraphDS myBFSgraph = new GraphDS();
            myBFSgraph.AddUnWeightedUndirectedEdge(1, 2);
            myBFSgraph.AddUnWeightedUndirectedEdge(1, 3);
            myBFSgraph.AddUnWeightedUndirectedEdge(2, 4);
            myBFSgraph.AddUnWeightedUndirectedEdge(3, 4);
            myBFSgraph.AddUnWeightedUndirectedEdge(4, 5);
            myBFSgraph.AddUnWeightedUndirectedEdge(4, 6);
            numberOfNodes = 6;
            Console.WriteLine("\n \n---------------BFS Iterative-----------------");
            nodeCount = myBFSgraph.BFSIterative(1, new bool[numberOfNodes + 1]);// the +1 coz i am starting nodes from 1 instaed of zero
            Console.WriteLine("\n BFS node count starting at node 1: " + nodeCount);
            if (nodeCount != 6)
                Console.WriteLine("\n Error with BFS");
            nodeCount = myBFSgraph.BFSIterative(0, new bool[numberOfNodes + 1]);
            Console.WriteLine("\n BFS node count starting at node 0: " + nodeCount);
            if (nodeCount != 1)
                Console.WriteLine("\n Error with BFS");


            Console.WriteLine("\n \n---------------BFS Recursive-----------------");
            nodeCount = myBFSgraph.BFSRecursive(1, new bool[numberOfNodes + 1]);// the +1 coz i am starting nodes from 1 instaed of zero
            Console.WriteLine("\n BFS node count starting at node 1: " + nodeCount);
            if (nodeCount != 6)
                Console.WriteLine("\n Error with BFS");
            nodeCount = myBFSgraph.BFSRecursive(0, new bool[numberOfNodes + 1]);
            Console.WriteLine("\n BFS node count starting at node 0: " + nodeCount);
            if (nodeCount != 1)
                Console.WriteLine("\n Error with BFS");

            GraphDS myBFSgraph1 = new GraphDS();
            myBFSgraph1.AddUnWeightedUndirectedEdge(0, 1);
            myBFSgraph1.AddUnWeightedUndirectedEdge(0, 2);
            myBFSgraph1.AddUnWeightedUndirectedEdge(0, 3);
            myBFSgraph1.AddUnWeightedUndirectedEdge(2, 9);
            myBFSgraph1.AddUnWeightedUndirectedEdge(8, 2);
            myBFSgraph1.AddUnWeightedUndirectedEdge(3, 4);
            myBFSgraph1.AddUnWeightedUndirectedEdge(10, 11);
            myBFSgraph1.AddUnWeightedUndirectedEdge(12, 13);
            myBFSgraph1.AddUnWeightedUndirectedEdge(3, 5);
            myBFSgraph1.AddUnWeightedUndirectedEdge(5, 7);
            myBFSgraph1.AddUnWeightedUndirectedEdge(5, 6);
            myBFSgraph1.AddUnWeightedUndirectedEdge(0, 10);
            myBFSgraph1.AddUnWeightedUndirectedEdge(11, 12);
            numberOfNodes = 14;
            Console.WriteLine("\n \n---------------BFS Recursive - Testing William Example-----------------");
            nodeCount = myBFSgraph1.BFSRecursive(0, new bool[numberOfNodes]);
            Console.WriteLine("\n BFS node count starting at node 1: " + nodeCount);

            #endregion

            #region Shortest Path - Modified BFS
           
            Console.WriteLine("\n \n---------------BFS Shortest Path of Unweighted Graph-----------------");
            ShortestPathBFS myBFSgraph2 = new ShortestPathBFS();
            myBFSgraph2.ShortestPath_Main();
           
            #endregion


              #region Rooting a Tree
           
            Console.WriteLine("\n \n---------------Rooting a Tree-----------------");
            RootingTree rootTree = new RootingTree();
            rootTree.RootingTree_Main();
           
            #endregion
        }
    }
}
