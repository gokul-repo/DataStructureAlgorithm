using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Sorting
{
    public class SelectionSort
    {
        public void main()
        {
            int[] list = new int[] { 8, 5, 3, 7, 2, 4, 1, 9, 6 };
            Console.WriteLine("----------------Selection Sort---------------");
            Console.WriteLine("Before Sort --->");
            PrintArray(list);
            SelectSort(list);
            Console.WriteLine("After Sort --->");
            PrintArray(list);

        }

        public void SelectSort(int[] unsortedArray)
        {
            int n = unsortedArray.Length;
            for (int i = 0; i < n; i++)
            {
                int minIdx = i;
                for (int j = i; j < n; j++)
                {
                    if (unsortedArray[j] < unsortedArray[minIdx])
                    {
                        minIdx = j;
                    }
                }
                int temp = unsortedArray[i];
                unsortedArray[i] = unsortedArray[minIdx];
                unsortedArray[minIdx] = temp;
            }
        }
    }
}