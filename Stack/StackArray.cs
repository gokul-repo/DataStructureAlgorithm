using System;

namespace DataStructureAlgorithm.Stack
{
    public class StackArray
    {
        public static  int Size = 100;
        public int[] StackArr = new int[Size];
        public int Top;

        public StackArray(){
            Top =-1;
        }
       
        //1. Push
        public void Push(int val){
            if (Top >= Size){   
                Console.WriteLine("Stack is Full");     
                return;
            }
            StackArr[++Top]= val;
        }

        //2. Pop
        public int Pop(){
            if (Top < 0){
                Console.WriteLine("Stack is EMpty");
                return 0;
            }
            return StackArr[Top--];            
        }
        //3. Peek
        public int Peek(){
            if (Top <0){
                Console.WriteLine("Stack is EMpty");
                return 0;
            }
            return StackArr[Top];
        }
        //4. IsEmpty
        public bool IsEmpty(){
            if (Top <0){
                return true;
            }
            return false;
        }
         //5. IsFull   
        public bool IsFull(){
             if (Top >= Size){               
                return true;               
            }
            return false;
        }     
        //6. Print
        public void Print(){
            if (Top < 0){
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("The Stack List is :");
            for(int i = Top ; i>=0;i--){
                Console.WriteLine(StackArr[i]);
            }
            Console.WriteLine("-------------------------");
        }
    }
}