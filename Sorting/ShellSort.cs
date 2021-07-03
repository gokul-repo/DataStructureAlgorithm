using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Sorting
{
    public class ShellSort
    {
         public void main()
        {
            int[] list = new int[] { 8, 5, 3, 7, 2, 4, 1, 9, 6 };
            Console.WriteLine("----------------Shell Sort---------------");
            Console.WriteLine("Before Sort --->");
            PrintArray(list);
            Shell(list);
            Console.WriteLine("After Sort --->");
            PrintArray(list);

        }
        public void Shell(int[] list){
            int n = list.Length;
            //keep reducing the gap by dividing by 2
            for(int gap=n/2;gap>0;gap/=2){
                for(int i=gap;i<n;i++){
                    int temp = list[i];
                    int j=i;
                    for(j=i;j>=gap && list[j-gap]>temp;j-=gap){
                        list[j]=list[j-gap];
                    }
                    list[j]=temp;
                }
            }
        }

    }
}