using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Algortihms
{
    public class MinHeap
    {
        public int HeapSize;
        public int HeapCapacity;
        public int[] HeapList;

        public MinHeap(int size)
        {
            HeapList = new int[size];
            HeapCapacity = size;
            HeapSize = 0;
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

        public void Insert(int value)
        {
            if (HeapSize >= HeapCapacity)
            {
                Console.WriteLine("Heap is Full");
                return;
            }
            HeapList[HeapSize] = value;
            HeapifyBottomToTop(HeapSize);
            HeapSize++;
        }

        public void HeapifyBottomToTop(int index)
        {
            if (index < 1)
            {
                return;
            }
            int parent = GetParent(index);
            if (HeapList[index] < HeapList[parent])
            {
                int temp = HeapList[index];
                HeapList[index] = HeapList[parent];
                HeapList[parent] = temp;
                HeapifyBottomToTop(parent);
            }
        }

        public int Extract()
        {
            if (HeapSize == 0)
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            int extractedValue = HeapList[0];
            HeapList[0] = HeapList[HeapSize-1];
            HeapSize--;
            HeapifyTopToBottom(0);
            return extractedValue;
        }

        public void HeapifyTopToBottom(int index)
        {
            int left = GetLeftChild(index);
            int right = GetRighChild(index);
            int smallest = 0;
            if (left > HeapSize)
            {
                //if no child
                return;
            }
            else if (left == HeapSize)
            {
                //if only had left child
                if (HeapList[left] < HeapList[index])
                {
                    int temp = HeapList[index];
                    HeapList[index] = HeapList[left];
                    HeapList[left] = temp;
                    return;
                }

            }
            else
            {
                //if both child are there
                smallest = HeapList[left] < HeapList[right] ? left : right;                
                if (HeapList[smallest] < HeapList[index])
                {
                    int temp = HeapList[index];
                    HeapList[index] = HeapList[smallest];
                    HeapList[smallest] = temp;
                    HeapifyTopToBottom(smallest);
                }
            }
        }

         public void MinHeap_Main()
        {
            MinHeap myHeap = new MinHeap(7);
            myHeap.Insert(10);
            myHeap.Insert(20);
            myHeap.Insert(15);
            myHeap.Insert(30);
            myHeap.Insert(40);
            myHeap.Insert(5);
            myHeap.Insert(60);
            PrintArray(myHeap.HeapList);
            Console.WriteLine(myHeap.Extract());
            PrintArray(myHeap.HeapList);

        }
    }
}