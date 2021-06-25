using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class SingleSourceShortestPathTopSort : TopSort
    {
         public void SSSPTopSort_Main()
        {
            GraphDS mygraph = new GraphDS();
            mygraph.AddDirectedEdge(0, 1, 3);
            mygraph.AddDirectedEdge(0, 2, 2);
            mygraph.AddDirectedEdge(0, 5, 3);
            mygraph.AddDirectedEdge(1, 3, 1);
            mygraph.AddDirectedEdge(1, 2, 6);
            mygraph.AddDirectedEdge(2, 3, 1);
            mygraph.AddDirectedEdge(2, 4, 10);
            mygraph.AddDirectedEdge(3, 4, 5);
            mygraph.AddDirectedEdge(5, 4, 7);
            int numOfNodes = 7;
            var distance = dagShortestPath(mygraph.Graph,0, numOfNodes);   
            // Find the shortest path from 0 to 4 which is 8.0
            Console.WriteLine(distance[4]);                    
             // Find the shortest path from 0 to 6 which is Max int since 6 is not reachable!
            Console.WriteLine(distance[6]);
        }

        public int[] dagShortestPath(Dictionary<int, List<Edge>> graph, int source,int numOfNodes){
            
            var topSortOrder = DoTopSort(graph,numOfNodes);
            int[] distance=new int[numOfNodes];
            for (int i = 0; i <numOfNodes;i++)
                distance[i]=int.MaxValue;
            distance[source]=0;
            for (int i=0 ;i <numOfNodes;i++){
                if(distance[i]!= int.MaxValue){
                    if(graph.ContainsKey(i)){
                        var edges = graph[i];
                        foreach(var edge in edges){
                            int newDistance = distance[edge.From]+edge.Cost;
                            distance[edge.To]=Math.Min(distance[edge.To],newDistance);
                        }
                    }
                }
            }
            return distance;
        }

    }
}