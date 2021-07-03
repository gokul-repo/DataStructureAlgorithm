using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Algortihms
{
    public class HeapSort
    {
        public void HeapSort_Main()
        {
            int[] list = { 23, 12, 2, 87, 54, 21, 98, 31, 44, 10 };
            Console.WriteLine("----------Heap Sort-------------");
            Console.WriteLine("----------Heapify-------------");
            Console.WriteLine("Before ->");
            PrintArray(list);
            HeapSortHeapify(list);
            Console.WriteLine("After ->");
            PrintArray(list);
        }

        public void HeapSortHeapify(int[] list)
        {
            int n = list.Length;

            //1. Create Max heap first using heapify

            //here n/2-1 gives us the parent of the last leaf
            for (int i = (n / 2) - 1; i >= 0; i--)
            {
                Heapify(list, n, i);
            }

            //2. Extract element and do heapify

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = list[0];
                list[0] = list[i];
                list[i] = temp;
                Heapify(list,i,0);
            }
        }

        public void Heapify(int[] list, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && list[left] > list[largest])
            {
                largest = left;
            }

            if (right < n && list[right] > list[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = list[i];
                list[i] = list[largest];
                list[largest] = temp;
                Heapify(list, n, largest);
            }
        }
    }
}