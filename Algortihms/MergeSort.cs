using System;

namespace DataStructureAlgorithm.Algortihms
{
    //O(n *Log n)
    //T(n) = 2 T(n/2) + n
    // MAsters theorem for dividing functions (From Abdul bari's Video)
        //Case 2.1
        // logb a =1
        //  n^k =n so k =1        
    public class MergeSort
    {
        public void MergeSort_Main()
        {
            int[] list = { 23, 12, 2, 87, 54, 21, 98, 31, 44, 10 };
            Console.WriteLine("----------Merge Sort-------------");
            Console.WriteLine("----------Recursion-------------");
            Console.WriteLine("Before ->");
            Print(list);
            MergeSortRecursion(list, 0, list.Length - 1);
            Console.WriteLine("After ->");
            Print(list);
        }

        public void MergeSortRecursion(int[] list, int strt, int end)
        {
            int mid = (strt + end) / 2;
            if (strt >= end)
            {
                return;
            }
            MergeSortRecursion(list, strt, mid);
            MergeSortRecursion(list, mid + 1, end);
            Merge(list, strt, end, mid);
        }

        public void Merge(int[] list, int strt, int end, int mid)
        {
            int lArrayLength = mid - strt + 1;
            int rArrayLength = end - mid;
            int[] leftArray = new int[lArrayLength];
            int[] rightArray = new int[rArrayLength];
            for (int i = 0; i < lArrayLength; i++)
            {
                leftArray[i] = list[strt + i];
            }
            for (int j = 0; j < rArrayLength; j++)
            {
                rightArray[j] = list[mid + 1 + j];
            }

            int p = 0;
            int q = 0;
            int r = strt;
            while (p < lArrayLength && q < rArrayLength)
            {
                if (leftArray[p] <= rightArray[q])
                {
                    list[r] = leftArray[p];
                    p++;
                }
                else
                {
                    list[r] = rightArray[q];
                    q++;
                }
                r++;
            }
            while (p < lArrayLength)
            {
                list[r] = leftArray[p];
                r++;
                p++;
            }
            while (q < rArrayLength)
            {
                list[r] = rightArray[q];
                r++;
                q++;
            }


        }

        public static void Print(int[] list)
        {
            foreach (var item in list)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}