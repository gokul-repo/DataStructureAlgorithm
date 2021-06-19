using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class TopSortKahn
    {
        public void TopSortKahn_Main()
        {
            GraphDS mygraph = new GraphDS();
            mygraph.AddDirectedEdge(0, 2, 1);
            mygraph.AddDirectedEdge(0, 3, 1);
            mygraph.AddDirectedEdge(0, 6, 1);
            mygraph.AddDirectedEdge(1, 4, 1);
            mygraph.AddDirectedEdge(2, 6, 1);
            mygraph.AddDirectedEdge(3, 1, 1);
            mygraph.AddDirectedEdge(3, 4, 1);
            mygraph.AddDirectedEdge(4, 5, 1);
            mygraph.AddDirectedEdge(4, 8, 1);
            mygraph.AddDirectedEdge(6, 7, 1);
            mygraph.AddDirectedEdge(6, 11, 1);
            mygraph.AddDirectedEdge(7, 4, 1);
            mygraph.AddDirectedEdge(7, 12, 1);
            mygraph.AddDirectedEdge(9, 2, 1);
            mygraph.AddDirectedEdge(9, 10, 1);
            mygraph.AddDirectedEdge(10, 6, 1);
            mygraph.AddDirectedEdge(11, 12, 1);
            mygraph.AddDirectedEdge(12, 8, 1);
            int numOfNodes = 14;
            var topSortOrder = DoTopSort(mygraph.Graph, numOfNodes);
            // Prints: [0, 9, 13, 3, 2, 10, 1, 6, 7, 11, 4, 12, 5, 8]
            foreach (var item in topSortOrder)
            {
                Console.Write(item);
                Console.Write("--->");
            }
            Console.WriteLine();

            //Test 1

            GraphDS mygraph1 = new GraphDS();
            mygraph1.AddDirectedEdge(0, 1, 1);
            mygraph1.AddDirectedEdge(0, 2, 1);
            mygraph1.AddDirectedEdge(1, 2, 1);
            mygraph1.AddDirectedEdge(3, 1, 1);
            mygraph1.AddDirectedEdge(3, 2, 1);
            mygraph1.AddDirectedEdge(2, 4, 1);
            mygraph1.AddDirectedEdge(4, 5, 1);
            numOfNodes = 6;
            topSortOrder = DoTopSort(mygraph1.Graph, numOfNodes);
            foreach (var item in topSortOrder)
            {
                Console.Write(item);
                Console.Write("--->");
            }
            Console.WriteLine();
            //test 2
            GraphDS mygraph2 = new GraphDS();
            mygraph2.AddDirectedEdge(0, 1, 1);
            mygraph2.AddDirectedEdge(0, 2, 1);
            mygraph2.AddDirectedEdge(0, 5, 1);
            mygraph2.AddDirectedEdge(1, 2, 1);
            mygraph2.AddDirectedEdge(1, 3, 1);
            mygraph2.AddDirectedEdge(2, 3, 1);
            mygraph2.AddDirectedEdge(2, 4, 1);
            mygraph2.AddDirectedEdge(3, 4, 1);
            mygraph2.AddDirectedEdge(5, 4, 1);
            numOfNodes = 6;
            topSortOrder = DoTopSort(mygraph2.Graph, numOfNodes);
            foreach (var item in topSortOrder)
            {
                Console.Write(item);
                Console.Write("--->");
            }
            Console.WriteLine();

            //Cycle test
            GraphDS mygraph3 = new GraphDS();
            mygraph3.AddDirectedEdge(0, 1, 1);
            mygraph3.AddDirectedEdge(1, 2, 1);
            mygraph3.AddDirectedEdge(2, 3, 1);
            mygraph3.AddDirectedEdge(3, 0, 1);
            topSortOrder = DoTopSort(mygraph3.Graph, numOfNodes);
            foreach (var item in topSortOrder)
            {
                Console.Write(item);
                Console.Write("--->");
            }
            Console.WriteLine();


        }

        public int[] DoTopSort(Dictionary<int, List<Edge>> graph, int numOfNodes)
        {
            int[] inDegree = new int[numOfNodes];
            int[] ordering = new int[numOfNodes];
            //InDegree calc
            for (int i = 0; i < numOfNodes; i++)
            {
                if (graph.ContainsKey(i))
                {
                    var edges = graph[i];
                    foreach (var edge in edges)
                    {
                        inDegree[edge.To] = inDegree[edge.To] + 1;
                    }
                }
            }
            //put all non dependencies into queue first
            System.Collections.Queue queue = new System.Collections.Queue();
            for (int i = 0; i < numOfNodes; i++)
            {
                if (inDegree[i] == 0)
                    queue.Enqueue(i);
            }
            int index = 0;
            while (queue.Count != 0)
            {
                int curr = (int)queue.Dequeue();
                ordering[index] = curr;
                index++;
                if (graph.ContainsKey(curr))
                {
                    var edges = graph[curr];
                    foreach (var edge in edges)
                    {
                        inDegree[edge.To]--;
                        if (inDegree[edge.To] == 0)
                            queue.Enqueue(edge.To);
                    }
                }
            }
            if (index != numOfNodes)
            {
                Console.WriteLine("There is a Cycle");
                //return null;
            }
            return ordering;
        }
    }
}