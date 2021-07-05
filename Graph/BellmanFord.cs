using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class BellmanFord
    {
        public void BellmanFord_Main()
        {
            GraphDS mygraph = new GraphDS();
            mygraph.AddDirectedEdge(0, 1, 1);
            mygraph.AddDirectedEdge(1, 2, 1);
            mygraph.AddDirectedEdge(2, 4, 1);
            mygraph.AddDirectedEdge(4, 3, -3);
            mygraph.AddDirectedEdge(3, 2, 1);
            mygraph.AddDirectedEdge(1, 5, 4);
            mygraph.AddDirectedEdge(1, 6, 4);
            mygraph.AddDirectedEdge(5, 6, 5);
            mygraph.AddDirectedEdge(6, 7, 4);
            mygraph.AddDirectedEdge(5, 7, 3);

            var output = BellmanFord_SSSP(mygraph.Graph, 0, 9);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("The Distance from source to {0} is {1}", i, output[i]);
            }

            GraphDS myGraph1 = new GraphDS();
            myGraph1.AddDirectedEdge(0, 1, 4);
            myGraph1.AddDirectedEdge(0, 2, 1);
            myGraph1.AddDirectedEdge(2, 1, 2);
            myGraph1.AddDirectedEdge(1, 3, 1);
            myGraph1.AddDirectedEdge(2, 3, 5);
            myGraph1.AddDirectedEdge(3, 4, 3);
            var output1 = BellmanFord_SSSP(myGraph1.Graph, 0, 5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The Distance from source to {0} is {1}", i, output1[i]);
            }
        }

        public int[] BellmanFord_SSSP(Dictionary<int, List<Edge>> mygraph, int source, int numberOfNodes)
        {
            int[] dist = new int[numberOfNodes];
            for (int i = 0; i < numberOfNodes; i++)
            {
                dist[i] = int.MaxValue;
            }
            dist[source] = 0;
            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                foreach (var item in mygraph)
                {
                    var edges = item.Value;
                    foreach (var edge in edges)
                    {
                        //int newDist = dist[edge.From] + edge.Cost;
                        if (dist[edge.From] + edge.Cost < dist[edge.To])
                        {
                            dist[edge.To] = dist[edge.From] + edge.Cost;
                        }
                    }
                }
            }

            //To detect Cycle - we can break here and print Negative cycle found.            
            foreach (var item in mygraph)
            {
                var edges = item.Value;
                foreach (var edge in edges)
                {
                    //int newDist = dist[edge.From] + edge.Cost;
                    if (dist[edge.From] + edge.Cost < dist[edge.To])
                    {
                        Console.WriteLine("Negative Cycle");
                        break;

                    }
                }
            }
            return dist;
        }
    }
}