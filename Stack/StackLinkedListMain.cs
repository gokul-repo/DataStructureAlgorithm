using System;

namespace DataStructureAlgorithm.Stack
{
    public class StackLinkedListMain
    {
        //1. Push
        //2. Pop
        //3. Peek
        //4. IsEmpty
        //5. IsFull  -- Not Implemented  -- Can implement tis if we have another property Total size of stack and  current size of stack in Stack Class.   
        //6. Print

        //TO DO :
        //1. Abdul Bari Problems
        //2. LeetCode - Stack chapter 
        
        //static void Main(string[] args)
         static void main(string[] args)
        {
           StackLinkedList stack = new StackLinkedList();
           Console.WriteLine(stack.IsEmpty());
           stack.Print();
           stack.Push(10);
           stack.Push(20);
           Console.WriteLine("The Element at Top is {0}", stack.Peek());
           stack.Push(30);
           Console.WriteLine("The Element at Top is {0}", stack.Peek());
           Console.WriteLine(stack.IsEmpty());
           stack.Print();
           Console.WriteLine("The Element Popped is {0}",stack.Pop());
           Console.WriteLine("The Element at Top is {0}", stack.Peek());
           stack.Print();
           Console.WriteLine("The Element Popped is {0}",stack.Pop());
           Console.WriteLine("The Element at Top is {0}", stack.Peek());
           stack.Print();
           Console.WriteLine("The Element Popped is {0}",stack.Pop());
           Console.WriteLine("The Element Popped is {0}",stack.Pop());
        }
    }
}