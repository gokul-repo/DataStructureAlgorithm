using System;

namespace DataStructureAlgorithm.Sorting
{
    public class QuickSort
    {
        public void main()
        {
            int[] list = new int[] { 8, 5, 3, 7, 2, 4, 1, 9, 6 };
            Console.WriteLine("----------------Quick Sort---------------");
            Console.WriteLine("Before Sort --->");
            Utilities.Print(list);
            QSort(list, 0, list.Length - 1);
            Console.WriteLine("After Sort --->");
            Utilities.Print(list);

        }

        public void QSort(int[] unsortedList, int l, int h)
        {
            if (l < h)
            {
                int pIndex = Partition(unsortedList, l, h);
                QSort(unsortedList, l, pIndex-1);
                QSort(unsortedList,pIndex+1,h);
            }

        }

        public int Partition(int[] unsortedList, int l, int h)
        {
            int pivot = unsortedList[h];
            int i=l-1;
            for(int j=l;j<=h-1;j++){
                if(unsortedList[j]<pivot){
                    i++;
                    int temp = unsortedList[j];
                    unsortedList[j]=unsortedList[i];
                    unsortedList[i]=temp;
                }
            }
            int tmp = unsortedList[h];
            unsortedList[h]=unsortedList[i+1];
            unsortedList[i+1]=tmp;
            return i+1;          
        }
    }
}