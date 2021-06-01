using System;

namespace DataStructureAlgorithm.Stack
{
    public class StackArrayMain
    {
         //1. Push
        //2. Pop
        //3. Peek
        //4. IsEmpty
        //5. IsFull        
        //6. Print
        
        //static void Main(string[] args)
        static void main(string[] args)
        {
           StackArray stack = new StackArray();
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