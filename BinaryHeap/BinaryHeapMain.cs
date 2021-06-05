namespace DataStructureAlgorithm.BinaryHeap
{
    public class BinaryHeapMain
    {
        //1. Insert in Heap
        //2. Delete in Heap
        //3. Create Heap
        //4. Heapify Top/Down


        //To DO - 
        //1. Heap Sort
        //2. Priority Queue


        static void main(string[] args)
        {
            Heap myHeap = new Heap(5);
            myHeap.Insert(10);
            myHeap.Insert(20);
            myHeap.Insert(30);
            myHeap.Insert(40);
            myHeap.Insert(50);
            myHeap.Insert(60);
            myHeap.PrintHeap();
            myHeap.Delete();
            myHeap.PrintHeap();

        }
    }
}