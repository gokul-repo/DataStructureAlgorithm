using System;

namespace DataStructureAlgorithm.Sorting
{
    public class RadixSort
    {
        //https://www.geeksforgeeks.org/radix-sort/
        //https://exceptionnotfound.net/radix-sort-csharp-the-sorting-algorithm-family-reunion/
        
        public void main()
        {
            int[] list = new int[] { 330, 8, 27, 4419, 55, 816, 419, 77, 622, 1234, 6, 9, 241, 1, 35, 7733, 4, 69 };
            Console.WriteLine("----------------Radix Sort---------------");
            Console.WriteLine("Before Sort --->");
            Utilities.Print(list);
            Radix(list);
            Console.WriteLine("After Sort --->");
            Utilities.Print(list);
        }

        public void Radix(int[] list)
        {
            int n = list.Length;
            int max = Max(list);
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(list, exp);
            }
        }

        public void CountingSort(int[] list, int exp)
        {

            int n = list.Length;
            int[] output = new int[n];
            int[] countArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                countArray[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                int idx = (list[i] / exp) % 10;
                countArray[idx]++;
            }
            for (int i = 1; i < 10; i++)
            {
                countArray[i] += countArray[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int idx = (list[i] / exp) % 10;
                output[countArray[idx]-1] = list[i];
                countArray[idx]--;
            }
            for (int i = 0; i < n; i++)
            {
                list[i] = output[i];
            }
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