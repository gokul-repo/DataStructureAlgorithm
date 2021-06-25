using System;

namespace DataStructureAlgorithm.Sorting
{
    public class BubbleSort
    {
        public void main()
        {
            int[] list = new int[] { 8, 5, 3, 7, 2, 4, 1, 9, 6 };
            Console.WriteLine("----------------Bubble Sort---------------");
            Console.WriteLine("Before Sort --->");
            Utilities.Print(list);
            Bubble(list);
            Console.WriteLine("After Sort --->");
            Utilities.Print(list);

        }

        public void Bubble(int[] unsortedList)
        {
            bool swap=false;
            var n = unsortedList.Length;
            for(int i=0;i<n;i++){                
                for(int j=0;j<n-1-i;j++){
                    if(unsortedList[j] > unsortedList[j+1]){
                        int temp = unsortedList[j];
                        unsortedList[j]= unsortedList[j+1];
                        unsortedList[j+1]=temp;
                        swap=true;
                    }
                }
                if(!swap){
                    return;
                }
            }
        }
    }
}