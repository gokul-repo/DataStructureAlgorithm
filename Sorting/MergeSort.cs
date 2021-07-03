using System;
using static DataStructureAlgorithm.Utilities.Utilities;

namespace DataStructureAlgorithm.Sorting
{
    public class MergeSort
    {
        public void main()
        {
            int[] list = new int[] { 8, 5, 3, 7, 2, 4, 1, 9, 6 };
            Console.WriteLine("----------------Merge Sort---------------");
            Console.WriteLine("Before Sort --->");
            PrintArray(list);
            MergeSorting(list, 0, list.Length - 1);
            Console.WriteLine("After Sort --->");
           PrintArray(list);
        }

        public void MergeSorting(int[] list, int strt, int end)
        {
            if (strt < end)
            {
                int mid= (strt+end)/2;
                MergeSorting(list,strt,mid);
                MergeSorting(list,mid+1,end);
                Merge(list,strt,end,mid);

            }
        }

        public void Merge(int[] list, int strt,int end,int mid){

            //array length for left and right sub array
            int leftArrayLength = mid-strt+1;
            int rightArrayLength = end-mid;
            //declare the arrays
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];
            //popuate the arrays
            for(int p=0;p<leftArrayLength;p++){
                leftArray[p]= list[strt+p];
            }
             for(int q=0;q<rightArrayLength;q++){
                rightArray[q]= list[mid+1+q];
            }
            int i=0,j=0,k=strt;
            //i pointer for left array
            //j pointer for right array
            //k pointer for main array
            //traverse through both left and right array , pick the smallest in each step and put it in the list, 
            //increment the pointer from which array the elemnt was picked
            //ncrement k too
            while (i < leftArrayLength && j<rightArrayLength){
                if(leftArray[i]<rightArray[j]){
                    list[k]=leftArray[i];
                    i++;
                }else{
                    list[k]=rightArray[j];
                    j++;
                }
                k++;
            }

            //Handling the scnario where either right or left array still have elements that are not merged into main array
            while(i<leftArrayLength){
                list[k]=leftArray[i];
                i++;
                k++;
            }
            while(j<rightArrayLength){
                list[k]=rightArray[j];
                j++;
                k++;
            }

        }


    }
}