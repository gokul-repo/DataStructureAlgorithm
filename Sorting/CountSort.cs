using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Sorting
{
    public class CountSort
    {
        public void main()
        {
            int[] list = new int[] { 8, 5, 3,9,9,4, 7,1,5,5, 2, 4, 1, 9, 6 ,8};
            Console.WriteLine("----------------Count Sort---------------");
            Console.WriteLine("Before Sort --->");
            PrintArray(list);
            Count(list);
            Console.WriteLine("After Sort --->");
            PrintArray(list);

        }

        public void Count(int[] list)
        {
            int n = list.Length;
            int max = Max(list);
            int[] countArray = new int[max + 1];
            for (int i = 0; i <= max; i++)
            {
                countArray[i] = -1;
            }
            for (int i = 0; i < n; i++)
            {
                int idx = list[i];
                countArray[idx] = countArray[idx] == -1 ? 1 : countArray[idx]+1;
            }
            int k=0;
            for (int i=0;i<=max;i++){
                while(countArray[i]>0){
                    list[k]=i;
                    k++;
                    countArray[i]--;
                }
            }
        }

        //Count sort GeekforGeeks way (This is what used in many articles)
        //https://www.geeksforgeeks.org/counting-sort/
         public void CountGG(int[] list)
        {
           //To Do
        }

        public int Max(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

    }
}