using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Sorting
{
    public class InsertionSort
    {
        public void main()
        {
            int[] list = new int[] { 8, 5, 3, 7, 2, 4, 1, 9, 6 };
            Console.WriteLine("----------------Insertion Sort---------------");
            Console.WriteLine("Before Sort --->");
            PrintArray(list);
            InsertSort(list);
            Console.WriteLine("After Sort --->");
            PrintArray(list);

        }

        public void InsertSort(int[] unsortedArray){
            int n = unsortedArray.Length;
            for(int i=1;i<n;i++){
                int curr = unsortedArray[i];
                int j=i-1;
                while(j>-1 && curr< unsortedArray[j]){
                    unsortedArray[j+1]=unsortedArray[j];
                    j--;
                }
                unsortedArray[j+1]=curr;

            }
        }
    }
}