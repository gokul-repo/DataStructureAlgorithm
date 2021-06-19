using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class TreeCenter : GraphDS
    {
        public void TreeCenter_Main()
        {
            GraphDS myGraph = new GraphDS();
            myGraph.AddUnWeightedUndirectedEdge(0, 1);
            myGraph.AddUnWeightedUndirectedEdge(2, 1);
            myGraph.AddUnWeightedUndirectedEdge(2, 3);
            myGraph.AddUnWeightedUndirectedEdge(3, 4);
            myGraph.AddUnWeightedUndirectedEdge(5, 3);
            myGraph.AddUnWeightedUndirectedEdge(2, 6);
            myGraph.AddUnWeightedUndirectedEdge(6, 7);
            myGraph.AddUnWeightedUndirectedEdge(6, 8);
            var list = FindCenter(myGraph.Graph);
            list.ForEach(Console.WriteLine);

            // Centers are 0
            Console.WriteLine("The center should be 0-------");
            GraphDS myGraph2 = new GraphDS();
            list = FindCenter(myGraph2.Graph);
            list.ForEach(Console.WriteLine);


            // Centers are 0,1
            Console.WriteLine("The center should be 0,1 -------");
            GraphDS myGraph3 = new GraphDS();
            myGraph3.AddUnWeightedUndirectedEdge(0, 1);
            list = FindCenter(myGraph3.Graph);
            list.ForEach(Console.WriteLine);


            // Centers are 1
            Console.WriteLine("The center should be 1 -------");
            GraphDS myGraph4 = new GraphDS();
            myGraph4.AddUnWeightedUndirectedEdge(0, 1);
            myGraph4.AddUnWeightedUndirectedEdge(1, 2);
            list = FindCenter(myGraph4.Graph);
            list.ForEach(Console.WriteLine);

            // Centers are 1,2
              Console.WriteLine("The center should be 1 ,2 -------");
            GraphDS myGraph5 = new GraphDS();
            myGraph5.AddUnWeightedUndirectedEdge(0, 1);
            myGraph5.AddUnWeightedUndirectedEdge(1, 2);
            myGraph5.AddUnWeightedUndirectedEdge(2, 3);
            list = FindCenter(myGraph5.Graph);
            list.ForEach(Console.WriteLine);

            // Centers are 2,3
               Console.WriteLine("The center should be 2,3 -------");
            GraphDS myGraph6 = new GraphDS();
            myGraph6.AddUnWeightedUndirectedEdge(0, 1);
            myGraph6.AddUnWeightedUndirectedEdge(1, 2);
            myGraph6.AddUnWeightedUndirectedEdge(2, 3);
            myGraph6.AddUnWeightedUndirectedEdge(3, 4);
            myGraph6.AddUnWeightedUndirectedEdge(4, 5);
            myGraph6.AddUnWeightedUndirectedEdge(4, 6);
            list = FindCenter(myGraph6.Graph);
            list.ForEach(Console.WriteLine);   
        }
        //Finding Center
        /* 
            Check william Fiset video for algorithm            
        */
        public List<int> FindCenter(Dictionary<int, List<Edge>> Graph)
        {
            int n = Graph.Count;
            int[] degree = new int[n];
            List<int> leaves = new List<int>();
            foreach (var item in Graph)
            {
                degree[item.Key] = Graph[item.Key].Count;
                if (degree[item.Key] == 1 || degree[item.Key] == 0)
                { //Checking for zero here if the graph if single node graph
                    leaves.Add(item.Key);
                    degree[item.Key] = 0;
                }
            }
            int count = leaves.Count;
            while (count < n)
            {
                List<int> new_leaves = new List<int>();
                foreach (var item in leaves)
                {
                    var neighbors = Graph[item];
                    foreach (var node in neighbors)
                    {
                        degree[node.To] = degree[node.To] - 1;
                        if (degree[node.To] == 1)
                        {
                            new_leaves.Add(node.To);
                        }
                    }
                    degree[item] = 0;
                }
                count += new_leaves.Count;
                leaves = new_leaves;
            }
            return leaves;
        }
    }
}