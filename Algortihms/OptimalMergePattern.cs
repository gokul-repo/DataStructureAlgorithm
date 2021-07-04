using System;

namespace DataStructureAlgorithm.Algortihms
{
    //https://www.geeksforgeeks.org/optimal-file-merge-patterns/
    public class OptimalMergePattern
    {
        public void OMP_main(){
            int size =6;
            int[] files =  new int[] { 2, 3, 4, 5, 6, 7 };
            var output = minComputation(files,size);
            Console.WriteLine(output);
            files = new int[] { 2, 3, 5 , 7 , 9 , 13 };
            output = minComputation(files,size);
            Console.WriteLine(output);
        }

        public int minComputation(int[] list, int size){
            MinHeap myMinHeap = new MinHeap(size);
            foreach(var item in list){
                myMinHeap.Insert(item);
            }
            int count=0;
            while(myMinHeap.HeapSize>1){                
                int temp =myMinHeap.Extract()+myMinHeap.Extract();
                myMinHeap.Insert(temp);
                count=count+temp;
            }
            return count;
        }
    }
}