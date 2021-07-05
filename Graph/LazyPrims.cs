using System;
using System.Collections.Generic;
using DataStructureAlgorithm.PriorityQueue;

namespace DataStructureAlgorithm.Graph
{
    public class LazyPrims
    {
        GraphDS myGraph = new GraphDS();
        public bool[] visited;
        public PriorityQueue<Edge> pq = new PriorityQueue<Edge>(true);        
        public Edge[] mstEdges;
        public int totalMinCost = 0;        


        public void LazyPrims_Main()
        {
            myGraph.AddUndirectedEdge(0, 1, 9);
            myGraph.AddUndirectedEdge(0, 2, 0);
            myGraph.AddUndirectedEdge(0, 3, 5);
            myGraph.AddUndirectedEdge(0, 5, 7);
            myGraph.AddUndirectedEdge(1, 3, -2);
            myGraph.AddUndirectedEdge(1, 4, 3);
            myGraph.AddUndirectedEdge(1, 6, 4);
            myGraph.AddUndirectedEdge(2, 5, 6);
            myGraph.AddUndirectedEdge(3, 5, 2);
            myGraph.AddUndirectedEdge(3, 6, 3);
            myGraph.AddUndirectedEdge(4, 6, 6);
            myGraph.AddUndirectedEdge(5, 6, 1);
            int numberOfNodes = 7;
            PrimsMST(numberOfNodes);
            Console.WriteLine(totalMinCost);
        }

        public void PrimsMST(int numberOfNodes)
        {
            int m = numberOfNodes - 1;
            int edgeCount = 0;           
            visited = new bool[numberOfNodes];
            mstEdges = new Edge[m];            
            pq = new PriorityQueue<Edge>(true);
            // Add first edge to PQ
            AddEdge(0);

            while(pq.Count!=0 && edgeCount!=m){
                Edge edge = pq.Dequeue();
                int idx = edge.To;
                if (visited[idx]){
                    continue;
                }
                mstEdges[edgeCount]=edge;
                edgeCount++;
                totalMinCost=totalMinCost+edge.Cost;
                AddEdge(idx);
            }

        }

        public void AddEdge(int index)
        {
            visited[index] = true;
            if (myGraph.Graph.ContainsKey(index))
            {
                var edges = myGraph.Graph[index];
                foreach (var edge in edges)
                {
                    if (!visited[edge.To])
                    {
                        pq.Enqueue(edge.Cost, edge);
                    }
                }
            }
        }

    }
}