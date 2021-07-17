using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class Tarjans
    {

        public int UNVISITED = -1;
        public int[] ids;        
        public int[] lowLink;
        public bool[] onStack;        
        public int sccCount;
        public int id;
        public int[] sccs;

        public void TarjensSolve(Dictionary<int, List<Edge>> myGraph, int numberOfNodes){
            ids=new int[numberOfNodes];
            lowLink=new int[numberOfNodes];
            onStack=new bool[numberOfNodes];
            sccs = new int[numberOfNodes];
            sccCount=0;            
            for(int i =0;i<numberOfNodes;i++){
                ids[i]=UNVISITED;
            }
            // do dfs
            for(int i =0;i<numberOfNodes;i++){
                if(ids[i]==UNVISITED){
                    dfs(myGraph, i);
                }
            }            
        }

        public void dfs(Dictionary<int, List<Edge>> myGraph,int at){
            onStack[at]=true;
            ids[at]=id;
            lowLink[at]=id;
            id++;
            myStack.Push(at);
            if(myGraph.ContainsKey(at)){
                var edges= myGraph[at];
                foreach(var edge in edges){
                    if(ids[edge.To] == UNVISITED){
                        dfs(myGraph,edge.To);
                    }
                    if(onStack[edge.To]){
                        lowLink[at] = Math.Min(lowLink[edge.To],lowLink[at]);
                    }
                }
            }
            if(ids[at]==lowLink[at]){
                for(int node=(int)myStack.Pop();; node =(int)myStack.Pop()){
                    onStack[node]=false;
                    sccs[node]=sccCount;
                    if(node == at){
                        break;
                    }
                }
                sccCount++;
            }
        }

        public System.Collections.Stack myStack = new System.Collections.Stack();
        public void Tarjans_Main()
        {
            int numberOfNodes = 8;
            GraphDS myGraph = new GraphDS();
            myGraph.AddDirectedEdge(6, 0,1);
            myGraph.AddDirectedEdge(6, 2,1);
            myGraph.AddDirectedEdge(3, 4,1);
            myGraph.AddDirectedEdge(6, 4,1);
            myGraph.AddDirectedEdge(2, 0,1);
            myGraph.AddDirectedEdge(0, 1,1);
            myGraph.AddDirectedEdge(4, 5,1);
            myGraph.AddDirectedEdge(5, 6,1);
            myGraph.AddDirectedEdge(3, 7,1);
            myGraph.AddDirectedEdge(7, 5,1);
            myGraph.AddDirectedEdge(1, 2,1);
            myGraph.AddDirectedEdge(7, 3,1);
            myGraph.AddDirectedEdge(5, 0,1);                                              
            TarjensSolve(myGraph.Graph,numberOfNodes);
            Console.WriteLine(sccCount);
            for(int i=0;i<numberOfNodes;i++){
                Console.WriteLine("Node {0} belongs to component {1}" , i, sccs[i]);
            }

        }


    }
}