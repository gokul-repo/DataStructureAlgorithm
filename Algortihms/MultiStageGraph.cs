using System;

namespace DataStructureAlgorithm.Algortihms
{
    public class MultiStageGraph
    {
        public void MultiStageGraph_Main(){
            int numberOfStages =5;
            int numberOfVertices = 12;
            int[,] graph = new int[13,13]{
                {0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,9,7,3,2,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,4,2,1,0,0,0,0},
                {0,0,0,0,0,0,2,7,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,11,0,0,0,0},
                {0,0,0,0,0,0,0,11,8,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,6,5,0,0},
                {0,0,0,0,0,0,0,0,0,4,3,0,0},
                {0,0,0,0,0,0,0,0,0,0,5,6,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,4},
                {0,0,0,0,0,0,0,0,0,0,0,0,2},
                {0,0,0,0,0,0,0,0,0,0,0,0,5},
                {0,0,0,0,0,0,0,0,0,0,0,0,0}
            };
            int[] cost = new int[numberOfVertices+1];
            int[] distance = new int[numberOfVertices+1];
            int[] path = new int[numberOfStages+1];
            cost[numberOfVertices]=0;
            distance[numberOfVertices]=numberOfVertices;

            for(int i = numberOfVertices-1;i>=1;i--){
                int min = int.MaxValue;
                for(int k = i+1;k<=numberOfVertices;k++){
                    if(graph[i,k]!=0 && graph[i,k]+cost[k]<min){
                        min = graph[i,k]+cost[k];
                        distance[i]=k;
                    }
                }
                cost[i]=min;
            }
            path[1]=1;
            path[numberOfStages]=numberOfVertices;
            for(int i=2;i<numberOfStages;i++){
                path[i]=distance[path[i-1]];               
            }

            //Print path
            for(int i=1;i<=numberOfStages;i++){
                 Console.Write(path[i]+"--->");
            }
            Console.WriteLine();
        }
    }
}