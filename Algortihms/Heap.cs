using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Algortihms
{
    public class Heap
    {
        public int HeapSize;
        public int HeapCapacity;
        public int[] HeapArray;

        public Heap(int size)
        {
            HeapArray = new int[size];
            HeapCapacity = size;
            HeapSize = 0;
        }

        public int GetLeftChild(int i)
        {
            return (2 * i) + 1;
        }

        public int GetRightChild(int i)
        {
            return (2 * i) + 2;
        }

        public int GetParent(int i)
        {
            return (i - 1) / 2;
        }

        public void Insert(int key)
        {
            if (HeapSize >= HeapCapacity)
            {
                Console.WriteLine("Heap is full");
            }

            HeapArray[HeapSize] = key;
            HeapifyBottomToTop(HeapSize);
            HeapSize++;

        }

        public void HeapifyBottomToTop(int index)
        {
            if (index < 1)
            {
                return;
            }
            int value = HeapArray[index];
            int parent = GetParent(index);
            if (value > HeapArray[parent])
            {
                int temp = HeapArray[parent];
                HeapArray[parent] = HeapArray[index];
                HeapArray[index] = temp;
            }
            HeapifyBottomToTop(parent);

        }

        public int Delete()
        {
            if (HeapSize == 0)
            {
                Console.WriteLine("Heap is empty");
            }
            int DeletedKey = HeapArray[0];
            HeapArray[0] = HeapArray[HeapSize - 1];            
            HeapSize--;
            HeapifyTopToBottom(0);
            HeapArray[HeapSize] = DeletedKey;
            return DeletedKey;
        }
        public void HeapifyTopToBottom(int index)
        {
            int left = GetLeftChild(index);
            int right = GetRightChild(index);
            if (HeapSize < left)
            {
                //Has no child
                return;
            }
            else if (HeapSize == left)
            {
                //Has Left CHild alone
                if (HeapArray[left] > HeapArray[index])
                {
                    int temp = HeapArray[left];
                    HeapArray[left] = HeapArray[index];
                    HeapArray[index] = temp;
                    return;
                }
            }
            else
            {  //Has both Left and right child
                int bigChild = HeapArray[left] > HeapArray[right] ? left : right;
                if (HeapArray[bigChild] > HeapArray[index])
                {
                    int temp = HeapArray[bigChild];
                    HeapArray[bigChild] = HeapArray[index];
                    HeapArray[index] = temp;
                    HeapifyTopToBottom(bigChild);                    
                }
            }
        }

        public void Heap_Main()
        {
            Heap myHeap = new Heap(7);
            myHeap.Insert(10);
            myHeap.Insert(20);
            myHeap.Insert(15);
            myHeap.Insert(30);
            myHeap.Insert(40);
            myHeap.Insert(5);
            myHeap.Insert(60);
            PrintArray(myHeap.HeapArray);
            myHeap.Delete();
            PrintArray(myHeap.HeapArray);

        }

    }
}