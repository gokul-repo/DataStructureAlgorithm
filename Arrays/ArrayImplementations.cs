using System;

namespace Code
{
    internal class ArrayImplementation
    {
        //static void Main(string[] args)
        static void main(string[] args)
        {
            //Array Operations
            //1. Create Array with user provided length
            //2. Print Array - O(n)
            //3. Add at End - O(1)
            //4. Add at Start - O(n)
            //5. Add at a given Index- O(n)
            //6. Delete at End -O(1)
            //7. Delete at Start -O(n)
            //8. Delete at a given Index -O(n)
            //9. Search - Doing only Linear search here
            //11. Find Min - O(n)
            //12. Reverse using auxillary array - O(n)
            //13. Reverse without auxillary array - O(n) but Space O(1)
            //14. Left Shift - O(n)
            //15. Left Rotate - O(n)
            //16. Right Shift - O(n)
            //17. Right Rotate - O(n) 
            //18. Sum and Average - O(n)
            //19. Insert in a sorted array 1 - FInd IDX where need to be inserted then use Insert at IDX method to insert - O(n)
            //20. Insert in a sorted array 2 - Insert Directly by start shifting (better perf than #19) - O(n)
            //21. Check if array is sorted -O(n)
            //22. Merge two Sorted Arrays -O(n)
            //23. Union - Simillar to Merge with little variation 
            //24. Intersection - Simillar to Merge with little variation 
            //25. Difference - Simillar to Merge with little variation 

            //To DO
            //1. Sort - TO DO ---in Algorithm
            //2. Search - Binary search
            //3. Negative numbers on left and Positive numbers on Right - (Two pointer approach)
            //4. LeetCode - Array 101
            //5. Abdul Badri - Student Challenges         



            Console.WriteLine("ENter the total number of Elements : ");
            int maxLength = Convert.ToInt16(Console.ReadLine());
            int[] myArr = new int[maxLength];
            int currLength = 0;
            Console.WriteLine("-----Initial Array ------");
            printArray(myArr);
            insertAtEnd(myArr, 10, ref currLength);
            insertAtEnd(myArr, 20, ref currLength);
            insertAtEnd(myArr, 30, ref currLength);
            insertAtEnd(myArr, 40, ref currLength);
            insertAtStart(myArr, 8, ref currLength);
            insertAtStart(myArr, 6, ref currLength);
            insertAtStart(myArr, 4, ref currLength);
            insertAtStart(myArr, 2, ref currLength);
            insertAtStart(myArr, 0, ref currLength);
            insertAtIdx(myArr, 15, ref currLength, 6);
            insertAtIdx(myArr, 25, ref currLength, 8);
            //insertAtIdx(myArr,25,ref currLength,100);
            //printArray(myArr);
            deleteAtEnd(myArr, ref currLength);
            deleteAtEnd(myArr, ref currLength);
            deleteAtStart(myArr, ref currLength);
            deleteAtStart(myArr, ref currLength);
            deleteAtIdx(myArr, ref currLength, 2);
            deleteAtIdx(myArr, ref currLength, 3);
            Console.WriteLine("-----FINAL Array ------");
            printArray(myArr);
            getCurrentLength(currLength);
            Console.WriteLine("----SEARCH------");
            int[] array = new int[] { 3, 5, 6, 7, 8, 9, 0, 11, 23, 46, 85, 34, 53, 12 };
            searchArray(array, 5);
            searchArray(array, 12);
            searchArray(array, 122);
            Console.WriteLine("------------MAX / MIN---------------------");
            Console.WriteLine("Maximum is {0}", Max(array));
            Console.WriteLine("Minimum is {0}", Min(array));
            Console.WriteLine("------------Reverse---------------------");
            reverse1(array);
            reverse2(array);
            Console.WriteLine("---------------------------------");
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("------------Left Shift---------------------");
            array1 = leftShift(array1);
            array1 = leftShift(array1);
            array1 = leftShift(array1);
            Console.WriteLine("------------Left Rotate---------------------");
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            array2 = leftRotate(array2);
            array2 = leftRotate(array2);
            array2 = leftRotate(array2);
            Console.WriteLine("------------Right SHift---------------------");
            int[] array3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            array3 = rightShift(array3);
            array3 = rightShift(array3);
            array3 = rightShift(array3);

            Console.WriteLine("------------Right Rotate---------------------");
            int[] array4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            array4 = rightRotate(array4);
            array4 = rightRotate(array4);
            array4 = rightRotate(array4);

            Console.WriteLine("------------Sum and AVG---------------------");
            int[] array5 = new int[] { 10, 10, 10, 10, 10 };
            SumnAvg(array5);
            int[] array6 = new int[] { 1, 2, 3, 4, 1 };
            SumnAvg(array6);
            Console.WriteLine("------------Is Array Sorted---------------------");
            int[] array7 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            isArraySorted(array7);
            int[] array8 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            isArraySorted(array8);
            int[] array9 = new int[] { 2, 1, 3, 4, 5, 6, 7, 8, 9, 1 };
            isArraySorted(array9);
            Console.WriteLine("------------Insert in Sorted Array 1---------------------");
            Console.WriteLine(" Before inserting - ");
            printArray(myArr);
            insertInSort(myArr, 15, ref currLength);
            Console.WriteLine(" After inserting - ");
            printArray(myArr);
            Console.WriteLine(" Before inserting - ");
            printArray(myArr);
            insertInSort(myArr, 22, ref currLength);
            Console.WriteLine(" After inserting - ");
            printArray(myArr);
            Console.WriteLine("------------Insert in Sorted Array 2---------------------");
            Console.WriteLine(" Before inserting - ");
            printArray(myArr);
            insertInSort(myArr, 12, ref currLength);
            Console.WriteLine(" After inserting - ");
            printArray(myArr);
            Console.WriteLine(" Before inserting - ");
            printArray(myArr);
            insertInSort(myArr, 24, ref currLength);
            Console.WriteLine(" After inserting - ");
            printArray(myArr);
            Console.WriteLine("------------Merge two sorted Arrays---------------------");
            int[] arr1 = new int[] { 2, 4, 6, 8, 10 };
            int[] arr2 = new int[] { 1, 3, 5, 7, 11 };
            mergeArrays(arr1, arr2);
             Console.WriteLine("---------------------------------");
            int[] arr3 = new int[] { 1, 4, 6, 8, 10 };
            int[] arr4 = new int[] { 1, 3, 5, 8, 11 };
            mergeArrays(arr3, arr4);
            Console.WriteLine("------------Union two sorted Arrays---------------------");
            int[] arr5 = new int[] { 1, 3, 5, 8, 10 };
            int[] arr6 = new int[] { 1, 3, 5, 7, 11 };
            unionArrays(arr5, arr6);
             Console.WriteLine("---------------------------------");
            int[] arr7 = new int[] { 1, 4, 6, 8, 10 };
            int[] arr8 = new int[] { 1, 3, 6, 8, 11 };
            unionArrays(arr7, arr8);
            Console.WriteLine("------------interection two sorted Arrays---------------------");            
            intersectionArrays(arr5, arr6);
            Console.WriteLine("---------------------------------");
            intersectionArrays(arr7, arr8);
            Console.WriteLine("---------------------------------");
            intersectionArrays(arr1, arr2);
            Console.WriteLine("------------difference b/w two sorted Arrays---------------------");            
            differenceArrays(arr5, arr6);
            Console.WriteLine("---------------------------------");
            differenceArrays(arr7, arr8);
            Console.WriteLine("---------------------------------");
            differenceArrays(arr1, arr2);

        }

        static void printArray(int[] myArr)
        {

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine("Element at {0} is {1}", i, myArr[i]);
            }
            Console.WriteLine("---------------------------------");
        }

        static void getCurrentLength(int currLength)
        {
            Console.WriteLine("Current Length is {0}", currLength);
        }

        static void insertAtEnd(int[] myArr, int value, ref int currLength)
        {
            if (currLength + 1 > myArr.Length)
            {
                Console.WriteLine("Cant Add more - MAX Reached");
                return;
            }
            myArr[currLength] = value;
            currLength = currLength + 1;
        }

        static void insertAtStart(int[] myArr, int value, ref int currLength)
        {
            if (currLength + 1 > myArr.Length)
            {
                Console.WriteLine("Cant Add More - MAX Reached");
                return;
            }
            for (int i = currLength - 1; i >= 0; i--)
            {
                myArr[i + 1] = myArr[i];
            }
            myArr[0] = value;
            currLength = currLength + 1;
        }
        static void insertAtIdx(int[] myArr, int value, ref int currLength, int idx)
        {
            if (idx > myArr.Length)
            {
                Console.WriteLine("Cant ADD at Index greater than Array Capacity");
                return;
            }
            if (currLength + 1 > myArr.Length)
            {
                Console.WriteLine("Cant Add More - MAX Reached");
                return;
            }
            for (int i = currLength - 1; i >= idx; i--)
            {
                myArr[i + 1] = myArr[i];
            }
            myArr[idx] = value;
            currLength = currLength + 1;
        }

        static void deleteAtEnd(int[] myArr, ref int currLength)
        {
            if (currLength == 0)
            {
                Console.WriteLine("No ELement to Delete");
                return;
            }
            myArr[currLength - 1] = 0;
            currLength = currLength - 1;
        }

        static void deleteAtStart(int[] myArr, ref int currLength)
        {
            if (currLength == 0)
            {
                Console.WriteLine("No ELement to Delete");
                return;
            }
            for (int i = 0; i < currLength; i++)
            {
                myArr[i] = myArr[i + 1];
            }
            myArr[currLength] = 0;
            currLength = currLength - 1;
        }

        static void deleteAtIdx(int[] myArr, ref int currLength, int idx)
        {
            if (idx > myArr.Length)
            {
                Console.WriteLine("Cant Delete at Index greater than Array Capacity");
                return;
            }
            if (currLength == 0)
            {
                Console.WriteLine("No ELement to Delete");
                return;
            }
            for (int i = idx; i < currLength; i++)
            {
                myArr[i] = myArr[i + 1];
            }
            currLength = currLength - 1;
        }

        static void searchArray(int[] array, int target)
        {
            foreach (int i in array)
            {
                if (i == target)
                {
                    Console.WriteLine("FOUND");
                    return;
                }
            }
            Console.WriteLine("NOT FOUND");
        }

        static int Max(int[] array)
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

        static int Min(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static void reverse1(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                reverseArray[j] = array[i];
            }
            Console.WriteLine("BEFORE");
            printLine(array);
            Console.WriteLine("AFTER");
            printLine(reverseArray);
        }

        static void reverse2(int[] array)
        {
            Console.WriteLine("BEFORE");
            printLine(array);

            int i = 0;
            int j = array.Length - 1;
            while (i < j)
            {
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
                i++;
                j--;
            }
            Console.WriteLine("AFTER");
            printLine(array);
        }

        static int[] leftShift(int[] array)
        {
            Console.WriteLine("BEFORE");
            printLine(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = 0;

            Console.WriteLine("AFTER");
            printLine(array);
            return array;
        }
        static int[] leftRotate(int[] array)
        {
            Console.WriteLine("BEFORE");
            printLine(array);
            int temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;

            Console.WriteLine("AFTER");
            printLine(array);
            return array;
        }


        static int[] rightShift(int[] array)
        {
            Console.WriteLine("BEFORE");
            printLine(array);
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = 0;

            Console.WriteLine("AFTER");
            printLine(array);
            return array;
        }
        static int[] rightRotate(int[] array)
        {
            Console.WriteLine("BEFORE");
            printLine(array);
            int temp = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;

            Console.WriteLine("AFTER");
            printLine(array);
            return array;
        }

        static void SumnAvg(int[] array)
        {
            float sum = 0;
            float avg = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            avg = sum / array.Length;
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("Avg is {0}", avg);
        }

        static void isArraySorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine("NOT SORTED");
                    return;
                }
            }
            Console.WriteLine("SORTED");
        }

        static void insertInSort(int[] myArr, int value, ref int currLength)
        {
            int idx = 0;
            for (int i = 0; i < currLength; i++)
            {
                if (myArr[i] > value)
                {
                    idx = i;
                    break;
                }
            }
            insertAtIdx(myArr, value, ref currLength, idx);
        }

        static void insertInSort2(int[] myArr, int value, ref int currLength)
        {
            int i = currLength - 1;
            while (myArr[i] > value)
            {
                myArr[i + 1] = myArr[i];
                i--;
            }
            myArr[i + 1] = value;
        }
        static void mergeArrays(int[] arr1, int[] arr2)
        {
            Console.WriteLine("Array 1 ");
            printLine(arr1);
            Console.WriteLine("Array 2 ");
            printLine(arr2);
            int m = arr1.Length;
            int n = arr2.Length;
            int[] result = new int[m + n];
            int i = 0, j = 0 ,k=0;
          while(i<m && j<n )
            {                
                if (arr1[i] < arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                    k++;
                }
                else if (arr1[i] > arr2[j])
                {
                    result[k] = arr2[j];
                    j++;
                    k++;
                }
                else
                {
                    result[k] = arr1[i];
                    result[k+1] = arr2[j];
                    i++;
                    j++;
                    k=k+2;
                }
            }
            while(i<m){
                result[k] = arr1[i];
                i++;
                k++;
            }
            while(j<n){
                result[k] = arr2[j];
                j++;
                k++;
            }
            Console.WriteLine("Final Array ");
            printLine(result);


        }

        //Same Code as Merge but with small difference at last Else statement --DIFF
         static void unionArrays(int[] arr1, int[] arr2)
        {
            Console.WriteLine("Array 1 ");
            printLine(arr1);
            Console.WriteLine("Array 2 ");
            printLine(arr2);
            int m = arr1.Length;
            int n = arr2.Length;
            int[] result = new int[m + n];
            int i = 0, j = 0 ,k=0;
          while(i<m && j<n )
            {                
                if (arr1[i] < arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                    k++;
                }
                else if (arr1[i] > arr2[j])
                {
                    result[k] = arr2[j];
                    j++;
                    k++;
                }
                else
                {
                    //DIFF
                    result[k] = arr1[i];                    
                    i++;
                    j++;
                    k++;
                }
            }
            while(i<m){
                result[k] = arr1[i];
                i++;
                k++;
            }
            while(j<n){
                result[k] = arr2[j];
                j++;
                k++;
            }
            Console.WriteLine("Final Array ");
            printLine(result);
        }

        //Again Simillar to Merge array
          static void intersectionArrays(int[] arr1, int[] arr2)
        {
            Console.WriteLine("Array 1 ");
            printLine(arr1);
            Console.WriteLine("Array 2 ");
            printLine(arr2);
            int m = arr1.Length;
            int n = arr2.Length;
            int[] result = new int[m + n];
            int i = 0, j = 0 ,k=0;
          while(i<m && j<n )
            {                
                if (arr1[i] == arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                    j++;
                    k++;
                }
                else if (arr1[i] > arr2[j])
                {                    
                    j++;                 
                }
                else
                {                
                    i++;                                     
                }
            }
            // while(i<m){
            //     result[k] = arr1[i];
            //     i++;
            //     k++;
            // }
            // while(j<n){
            //     result[k] = arr2[j];
            //     j++;
            //     k++;
            // }
            Console.WriteLine("Final Array ");
            printLine(result);
        }

        static void differenceArrays(int[] arr1, int[] arr2)
        {
            Console.WriteLine("Array 1 ");
            printLine(arr1);
            Console.WriteLine("Array 2 ");
            printLine(arr2);
            int m = arr1.Length;
            int n = arr2.Length;
            int[] result = new int[m + n];
            int i = 0, j = 0 ,k=0;
            while(i<m && j<n )
            {                
                if (arr1[i] < arr2[j])
                {
                    result[k] = arr1[i];
                    i++;
                    k++;
                }
                else if (arr1[i] > arr2[j])
                {
                    result[k] = arr2[j];
                    j++;
                    k++;
                }
                else
                {                 
                    i++;
                    j++;                 
                }
            }
            while(i<m){
                result[k] = arr1[i];
                i++;
                k++;
            }
            while(j<n){
                result[k] = arr2[j];
                j++;
                k++;
            }
            Console.WriteLine("Final Array ");
            printLine(result);
        }
        static void printLine(int[] array)
        {
            foreach (int l in array)
            {
                Console.Write(l);
                Console.Write("   ");
            }
            Console.WriteLine();
        }
    }


}
