using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.PriorityQueue
{
    public class PriorityQueue<T>
    {
        public class Node
        {
            public int Priority { get; set; }
            public T Object { get; set; }
        }

        public List<Node> queue = new List<Node>();
        public int heapSize = -1;
        public bool isMinHeap = false;
        public int Count { get { return queue.Count; } }

        public PriorityQueue(bool isMinPriorityQueue = false)
        {
            isMinHeap = isMinPriorityQueue;
        }

        public void Enqueue(int priority, T obj){
            Node newNode = new Node(){Object=obj,Priority =priority};
            queue.Add(newNode);
            heapSize++;
            if(isMinHeap){
                MinHeapifyBottomToTop(heapSize);
            }else{
                MaxHeapifyBottomToTop(heapSize);
            }
        }

        public void  MinHeapifyBottomToTop(int index){
            if(index <1){
                return;
            }
            int parent = GetParent(index);
            if(queue[index].Priority < queue[parent].Priority){
                Node temp = queue[index];
                queue[index]=queue[parent];
                queue[parent]=temp;
                MinHeapifyBottomToTop(parent);
            }

        }

         public void  MaxHeapifyBottomToTop(int index){
            if(index <1){
                return;
            }
            int parent = GetParent(index);
            if(queue[index].Priority > queue[parent].Priority){
                Node temp = queue[index];
                queue[index]=queue[parent];
                queue[parent]=temp;
                MaxHeapifyBottomToTop(parent);
            }

        }
        
        public T Dequeue(){
            var returnObject = queue[0];
            queue[0]=queue[heapSize];
            queue.RemoveAt(heapSize);
            heapSize--;
            if(isMinHeap){
                MinHeapifyTopToBottom(0);
            }
            else{
                MaxHeapifyTopToBottom(0);
            }
            return returnObject.Object;
        }

        public void MinHeapifyTopToBottom(int index){
            int left = GetLeftChild(index);
            int right = GetRighChild(index);
            int smallest=0;
            if(left>heapSize){
                return;
            }
            else if (left == heapSize){
                //if only had left child
                if (queue[left].Priority < queue[index].Priority)
                {
                    Node temp = queue[index];
                    queue[index] = queue[left];
                    queue[left] = temp;
                    return;
                }
            }else{
                //has two childs
                //if both child are there
                smallest = queue[left].Priority < queue[right].Priority ? left : right;                
                if (queue[smallest].Priority < queue[index].Priority)
                {
                    Node temp = queue[index];
                    queue[index] = queue[smallest];
                    queue[smallest] = temp;
                    MinHeapifyTopToBottom(smallest);
                }
            }

        }

          public void MaxHeapifyTopToBottom(int index){
            int left = GetLeftChild(index);
            int right = GetRighChild(index);
            int largest=0;
            if(left>heapSize){
                return;
            }
            else if (left == heapSize){
                //if only had left child
                if (queue[left].Priority > queue[index].Priority)
                {
                    Node temp = queue[index];
                    queue[index] = queue[left];
                    queue[left] = temp;
                    return;
                }
            }else{
                //has two childs
                //if both child are there
                largest = queue[left].Priority > queue[right].Priority ? left : right;                
                if (queue[largest].Priority > queue[index].Priority)
                {
                    Node temp = queue[index];
                    queue[index] = queue[largest];
                    queue[largest] = temp;
                    MaxHeapifyTopToBottom(largest);
                }
            }

        }


        public int GetLeftChild(int index)
        {
            return 2 * index + 1;
        }

        public int GetRighChild(int index)
        {
            return 2 * index + 2;
        }

        public int GetParent(int index)
        {
            return (index - 1) / 2;
        }

        public void PriorityQueue_Main()
        {
            //PriorityQueue<int> pq = new PriorityQueue<int>(true);
            PriorityQueue<int> pq = new PriorityQueue<int>();
            pq.Enqueue(10,10);
            pq.Enqueue(20,20);
            pq.Enqueue(15,15);
            pq.Enqueue(30,30);
            pq.Enqueue(40,40);
            pq.Enqueue(5,5);
            pq.Enqueue(60,60);
            //PrintArray(myHeap.HeapList);
            Console.WriteLine(pq.Dequeue());
            //PrintArray(myHeap.HeapList);

        }
    }
}