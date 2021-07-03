using System;

namespace DataStructureAlgorithm.Algortihms
{
    //O(Log n)
    //T(n) = T(n/2) +1
    // MAsters theorem for dividing functions (From Abdul bari's Video)
        //Case 2.1
        // log a =0
        //  n^k =1 so k =0
        //
    public class BinarySearch
    {
        public bool BinarySearchIterative (int[] list, int target){
            if(list.Length ==0){
                return false;
            }
            int l= 0;
            int r=list.Length-1;            
            while(l<=r){
                int mid = (l+r+1) /2;
                if(list[mid]==target){
                    return true;
                }else if(target<list[mid]){
                    r=mid-1;
                }else{
                    l=mid+1;
                }
            }
            return false;
        }

        public bool BinarySearchRecursive (int[] list, int target){
            return BinarySearchHelper(list,0,list.Length-1,target);            
        }

        public bool BinarySearchHelper(int[] list, int strt,int end,int target){
            int mid=(strt+end)/2;
            if (strt > end){
                return false;
            }
            if(list[mid]==target){
                return true;
            }else if(target<list[mid]){
                return BinarySearchHelper(list,strt,mid-1,target);
            }else{
                return BinarySearchHelper(list,mid+1,end,target);
            }
        }
        public void BinarySearchMain(){
            int[] list = {3,4,6,7,12,22,34,44,58,60,72,88,90,100,156,201};
            int[] list1 = {1,3,4,6,7,12,22,34,44,58,60,72,88,90,100,156,201};
            //True - even number of elements
            Console.WriteLine("---------Iterative -------------");
            Console.WriteLine("---------True -------------");
            Console.WriteLine(BinarySearchIterative(list,7));
            Console.WriteLine(BinarySearchIterative(list,22));
            Console.WriteLine(BinarySearchIterative(list,100));
            Console.WriteLine(BinarySearchIterative(list,58));
            Console.WriteLine(BinarySearchIterative(list,3));
            Console.WriteLine(BinarySearchIterative(list,201));
            //false - even number of elements
            Console.WriteLine("---------false -------------");
            Console.WriteLine(BinarySearchIterative(list,205));
            Console.WriteLine(BinarySearchIterative(list,1));
            Console.WriteLine(BinarySearchIterative(list,10));
            Console.WriteLine(BinarySearchIterative(list,91));
            Console.WriteLine(BinarySearchIterative(list,45));
            Console.WriteLine("----------------------");
            //True - odd number of elements
            Console.WriteLine("---------True -------------");
            Console.WriteLine(BinarySearchIterative(list1,7));
            Console.WriteLine(BinarySearchIterative(list1,22));
            Console.WriteLine(BinarySearchIterative(list1,100));
            Console.WriteLine(BinarySearchIterative(list1,58));
            Console.WriteLine(BinarySearchIterative(list1,3));
            Console.WriteLine(BinarySearchIterative(list1,201));
            //false - odd number of elements
            Console.WriteLine("---------False -------------");
            Console.WriteLine(BinarySearchIterative(list1,205));
            Console.WriteLine(BinarySearchIterative(list1,0));
            Console.WriteLine(BinarySearchIterative(list1,10));
            Console.WriteLine(BinarySearchIterative(list1,91));
            Console.WriteLine(BinarySearchIterative(list1,45));

             Console.WriteLine("---------Recursive -------------");
             //True - even number of elements
             Console.WriteLine("---------True -------------");
            Console.WriteLine(BinarySearchRecursive(list,7));
            Console.WriteLine(BinarySearchRecursive(list,22));
            Console.WriteLine(BinarySearchRecursive(list,100));
            Console.WriteLine(BinarySearchRecursive(list,58));
            Console.WriteLine(BinarySearchRecursive(list,3));
            Console.WriteLine(BinarySearchRecursive(list,201));
            //false - even number of elements
            Console.WriteLine("---------False -------------");
            Console.WriteLine(BinarySearchRecursive(list,205));
            Console.WriteLine(BinarySearchRecursive(list,1));
            Console.WriteLine(BinarySearchRecursive(list,10));
            Console.WriteLine(BinarySearchRecursive(list,91));
            Console.WriteLine(BinarySearchRecursive(list,45));
            Console.WriteLine("----------------------");
            Console.WriteLine("---------True -------------");
            //True - odd number of elements
            Console.WriteLine(BinarySearchRecursive(list1,7));
            Console.WriteLine(BinarySearchRecursive(list1,22));
            Console.WriteLine(BinarySearchRecursive(list1,100));
            Console.WriteLine(BinarySearchRecursive(list1,58));
            Console.WriteLine(BinarySearchRecursive(list1,3));
            Console.WriteLine(BinarySearchRecursive(list1,201));
            Console.WriteLine("---------False -------------");
            //false - odd number of elements
            Console.WriteLine(BinarySearchRecursive(list1,205));
            Console.WriteLine(BinarySearchRecursive(list1,0));
            Console.WriteLine(BinarySearchRecursive(list1,10));
            Console.WriteLine(BinarySearchRecursive(list1,91));
            Console.WriteLine(BinarySearchRecursive(list1,45));
        }
        
    }
}