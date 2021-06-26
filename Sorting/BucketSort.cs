using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Sorting
{
    public class BucketSort
    {
        //Different implementation than Abdul Bari
        //Below articles were usefull
        //https://www.geeksforgeeks.org/bucket-sort-2/
        //https://exceptionnotfound.net/bucket-sort-csharp-the-sorting-algorithm-family-reunion/
        public void main()
        {
            int[] list = new int[] { 43, 17, 87, 92, 31, 6, 96, 13, 66, 62, 4 };
            Console.WriteLine("----------------Bucket Sort---------------");
            Console.WriteLine("Before Sort --->");
            Utilities.Print(list);
            BinSort(list);
            Console.WriteLine("After Sort --->");
            Utilities.Print(list);

        }

        public void BinSort(int[] unsortedArray)
        {
            int numOfBuckets = 10;
            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<int>();
            }
            //Iterate through each element in the array and put the item in the appropriate bucket
            foreach (var item in unsortedArray)
            {
                int bucket = item / 10;
                buckets[bucket].Add(item);
            }

            int k = 0;
            foreach (var list in buckets)
            {
                list.Sort();
                foreach (var item in list)
                {
                    unsortedArray[k] = item;
                    k++;
                }
            }

        }
    }
}