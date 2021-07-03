using System;

namespace DataStructureAlgorithm.Algortihms
{
    public class QuickSort
    {
        public void QuickSort_Main()
        {
            int[] list = new int[] { 18, 5, 23, 7, 2, 42, 11, 98, 68, 87, 32, 12 };
            Console.WriteLine("----------------Quick Sort---------------");
            Console.WriteLine("Before Sort --->");
            Print(list);
            QSort(list, 0, list.Length - 1);
            Console.WriteLine("After Sort --->");
            Print(list);
        }

        public void QSort(int[] list,int strt,int end){
            if (strt<end){
                int pIndex = Partitioning(list,strt,end);
                QSort(list,strt,pIndex-1);
                QSort(list,pIndex+1,end);
            }
        }

        public int Partitioning(int[] list, int strt, int end){
            int pivot = list[end];
            int i=strt-1;
            for(int j=strt;j<=end-1;j++){
                if(list[j] <pivot){
                    i++;
                    int temp = list[j];
                    list[j]=list[i];
                    list[i]=temp;
                }
            }
            int t = list[end];
            list[end]=list[i+1];
            list[i+1]=t;
            return i+1;


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