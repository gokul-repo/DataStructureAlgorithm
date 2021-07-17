using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class EulerianPath
    {
        public int edgeCount;
        public int[] inDegree;
        public int[] outDegree;

        public LinkedList<int> list = new LinkedList<int>();

        public void EulerianPath_Main()
        {
            GraphDS myGraph = new GraphDS();
            myGraph.AddDirectedEdge(1, 2, 1);
            myGraph.AddDirectedEdge(1, 3, 1);
            myGraph.AddDirectedEdge(2, 2, 1);
            myGraph.AddDirectedEdge(2, 4, 1);
            myGraph.AddDirectedEdge(2, 4, 1);
            myGraph.AddDirectedEdge(3, 1, 1);
            myGraph.AddDirectedEdge(3, 2, 1);
            myGraph.AddDirectedEdge(3, 5, 1);
            myGraph.AddDirectedEdge(4, 3, 1);
            myGraph.AddDirectedEdge(4, 6, 1);
            myGraph.AddDirectedEdge(5, 6, 1);
            myGraph.AddDirectedEdge(6, 3, 1);
            int numberOfNodes = 7;
            var path = GetEulerianPath(myGraph.Graph, numberOfNodes);
            Utilities.Utilities.PrintArray(path);
        }

        public int[] GetEulerianPath(Dictionary<int, List<Edge>> myGraph, int numOfNodes)
        {
            SetupForEulerianPath(myGraph, numOfNodes);
            if (!HasEulerianPath(numOfNodes))
            {
                return null;
            }
            int startNode = FindStartNode(numOfNodes);
            dfs(myGraph, numOfNodes, startNode); 

            if(list.Count != edgeCount+1){
                return null;
            }     
            int[] soln = new int[edgeCount + 1];
            for (int i = 0; list.Count!=0; i++) {
                soln[i] = list.First.Value;
                list.RemoveFirst();
            }
            return soln;      
        }

        public void SetupForEulerianPath(Dictionary<int, List<Edge>> myGraph, int numOfNodes)
        {
            inDegree = new int[numOfNodes];
            outDegree = new int[numOfNodes];
            edgeCount = 0;
            foreach (var vertex in myGraph)
            {
                foreach (var edge in vertex.Value)
                {
                    outDegree[edge.From]++;
                    inDegree[edge.To]++;
                    edgeCount++;
                }
            }
        }

        public bool HasEulerianPath(int numOfNodes)
        {
            if (edgeCount == 0)
            {
                return false;
            }
            int startNode = 0;
            int endNode = 0;
            for (int i = 0; i < numOfNodes; i++)
            {
                if (inDegree[i] - outDegree[i] > 1 || outDegree[i] - inDegree[i] > 1)
                {
                    return false;
                }
                else if (inDegree[i] - outDegree[i] == 1)
                {
                    endNode++;
                }
                else if (outDegree[i] - inDegree[i] == 1)
                {
                    startNode++;
                }
            }

            if ((startNode == 0 && endNode == 0) || (startNode == 1 && endNode == 1))
            {
                return true;
            }
            return false;

        }

        public int FindStartNode(int numOfNodes)
        {
            int start = 0;
            for (int i = 0; i < numOfNodes; i++)
            {
                if (outDegree[i] - inDegree[i] == 1)
                {
                    return i;
                }
                if (outDegree[i] > 0)
                {
                    start = i;
                }
            }
            return start;
        }

        public void dfs(Dictionary<int, List<Edge>> myGraph, int numOfNodes, int currNode)
        {
            while (outDegree[currNode] != 0)
            {
                var edges = myGraph[currNode];                
                dfs(myGraph, numOfNodes, edges[--outDegree[currNode]].To);
                
                
            }
            list.AddFirst(currNode);
        }
    }
}