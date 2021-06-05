using System;

namespace DataStructureAlgorithm.BinaryHeap
{
    public class Heap
    {
        public int[] HeapArray;
        public int HeapSize;
        public Heap(int size){
            HeapArray= new int[size+1];
            HeapSize=0;
        }

        public int PeekOfHeap(){
            if (HeapSize ==0){
                  return 0;  
            }
            return HeapArray[1];

        }
        public int SizeOfHeap(){           
            return HeapSize;
        }

        public int GetLeftChildIndex(int i){
            return 2*i;
        }

        public int GetRightChildIndex(int i){
            return (2*i)+1;
        }
        public int GetParentIndex(int i){
            return i/2;
        }


        public void Insert(int val){
            //If heap Size is full, do not insert
            if(HeapSize + 1 == HeapArray.Length){
                Console.WriteLine("Heap is full ");
                return;
            }
            //Add the element at the end of the heap and call heapify.
            HeapSize++;
            HeapArray[HeapSize]= val;
            HeapifyBottomToTop(HeapSize); 
        }

        public void HeapifyBottomToTop(int index){
            if (index <=1){
                return;
            }
            int parentIndex = GetParentIndex(index);
            if(HeapArray[parentIndex] < HeapArray[index]){
                int temp = HeapArray[parentIndex];
                HeapArray[parentIndex]= HeapArray[index];
                HeapArray[index]= temp;
            }
            HeapifyBottomToTop(parentIndex);

        }

        
        public int Delete(){
            if (HeapSize == 0){
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            int extractedVal = HeapArray[1];
            HeapArray[1]= HeapArray[HeapSize];
            HeapSize--;
            HeapifyTopToBottom(1);
            return extractedVal;
        }

        public void HeapifyTopToBottom(int index){           
            int left = GetLeftChildIndex(index);
            int right = GetRightChildIndex(index);
            int bigChild=0;
            if(HeapSize < left){
                //This means we reached the end of the heap
                return;
            }else if(HeapSize==left){
                //this means that the current index only have left index
                if(HeapArray[index]<HeapArray[left]){
                    int temp = HeapArray[index];
                    HeapArray[index] = HeapArray[left];
                    HeapArray[left]=temp;
                }
                return;
            }else{
                //this means that current index has both left and right child

                //Find which child has max value
                bigChild = HeapArray[left] >HeapArray[right]? left : right;
                //compare the max child with index
                 if(HeapArray[index]<HeapArray[bigChild]){
                    int temp = HeapArray[index];
                    HeapArray[index] = HeapArray[bigChild];
                    HeapArray[bigChild]=temp;
                }
            }
            HeapifyTopToBottom(bigChild);
            
        }

        public void PrintHeap(){
            for (int i=1;i<=HeapSize;i++){
                Console.Write(HeapArray[i]);
                Console.Write("  ");
            }
            Console.WriteLine();
        }


    }

}