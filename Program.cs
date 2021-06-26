using System;
using DataStructureAlgorithm.Sorting;



namespace DataStructureAlgorithm
{
    internal class Program
    {
        //1. BFS - Adj. Matrix
        //2. BFS - Adj. List
        //3. DFS - Adj. Matrix
        //4. DFS - Adj. List

        static void Main(string[] args)
        {
            // BubbleSort bs = new BubbleSort();
            // bs.main();

            // InsertionSort inSort = new InsertionSort();
            // inSort.main();

            //  SelectionSort selectSort = new SelectionSort();
            // selectSort.main();

            // QuickSort qs = new QuickSort();
            // qs.main();

            // MergeSort ms = new MergeSort();
            // ms.main();
          
            CountSort cs = new CountSort();
            cs.main();
        }
    }
}
