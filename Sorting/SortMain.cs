namespace DataStructureAlgorithm.Sorting
{
    public class SortMain
    {
        static void Sorting_Main(string[] args)
        {
            BubbleSort bs = new BubbleSort();
            bs.main();

            InsertionSort inSort = new InsertionSort();
            inSort.main();

             SelectionSort selectSort = new SelectionSort();
            selectSort.main();

            QuickSort qs = new QuickSort();
            qs.main();

            MergeSort ms = new MergeSort();
            ms.main();
          
            CountSort cs = new CountSort();
            cs.main();

            BucketSort bucketSort = new BucketSort();
            bucketSort.main();
           
             RadixSort rs = new RadixSort();
            rs.main();

            ShellSort ss = new ShellSort();
            ss.main();            
        }
    }
}