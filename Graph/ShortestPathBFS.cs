using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class ShortestPathBFS : GraphDS
    {
         //Modified BFS for Shortest Path

        public List<int> ShortPath_BFS(int start,int end, int n)
        {
            int[] prev = new int[n];
            for (int i=0;i<prev.Length;i++){
                prev[i]=-1;
            }
            prev =BFS_Modified(10,prev,n);
            List<int> path = new List<int>();
            for (int at = end; at != -1; at = prev[at]) {
                path.Add(at);
            }
            path.Reverse();
            if (path[0] == start) 
                return path;
            path.Clear();   
            return path;
        }
        public int[] BFS_Modified(int start, int[] prev,int n)
        {
            System.Collections.Queue myQueue = new System.Collections.Queue();
            myQueue.Enqueue(start); 
            bool[] visited = new bool[n];          
            visited[start] = true;

            while (myQueue.Count != 0)
            {
                int currKey = (int)myQueue.Dequeue();                
                if (Graph.ContainsKey(currKey))
                {
                    var edges = Graph[currKey];
                    foreach (var edge in edges)
                    {
                        if (!visited[edge.To])
                        {   prev[edge.To]=edge.From;
                            myQueue.Enqueue(edge.To);
                            visited[edge.To]=true;                            
                        }
                    }
                }
            }
            return prev;
        }

        public void ShortestPath_Main(){
            int numberOfNodes=13;
            ShortestPathBFS myBFSgraph2 = new ShortestPathBFS();
            myBFSgraph2.AddUnWeightedUndirectedEdge(0, 7);
            myBFSgraph2.AddUnWeightedUndirectedEdge(0, 9);
            myBFSgraph2.AddUnWeightedUndirectedEdge(0, 11);
            myBFSgraph2.AddUnWeightedUndirectedEdge(7, 11);
            myBFSgraph2.AddUnWeightedUndirectedEdge(7, 6);
            myBFSgraph2.AddUnWeightedUndirectedEdge(7, 3);
            myBFSgraph2.AddUnWeightedUndirectedEdge(6, 5);
            myBFSgraph2.AddUnWeightedUndirectedEdge(3, 4);
            myBFSgraph2.AddUnWeightedUndirectedEdge(2, 3);
            myBFSgraph2.AddUnWeightedUndirectedEdge(2, 12);
            myBFSgraph2.AddUnWeightedUndirectedEdge(12, 8);
            myBFSgraph2.AddUnWeightedUndirectedEdge(8, 1);
            myBFSgraph2.AddUnWeightedUndirectedEdge(1, 10);
            myBFSgraph2.AddUnWeightedUndirectedEdge(10, 9);
            myBFSgraph2.AddUnWeightedUndirectedEdge(9, 8);            
            var path = myBFSgraph2.ShortPath_BFS(10,5,numberOfNodes);            
            foreach(var item in path){
                Console.Write(item);
                Console.Write("--->");
            }
            Console.WriteLine();
        }

    }
}