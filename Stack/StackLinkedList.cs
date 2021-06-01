using System;

namespace DataStructureAlgorithm.Stack
{
    public class StackLinkedList
    {
        public Node Top;

        public StackLinkedList()
        {
            Top = null;
        }


        //1. Push
        public void Push(int val)
        {
            Node newNode = new Node(val);
            if (Top == null)
            {
                Top = newNode;
                return;
            }
            newNode.Next = Top;
            Top = newNode;
        }
        //2. Pop
        public int Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("The STack Is EMpty");
                return 0;
            }
            int val = Top.Value;
            Top = Top.Next;
            return val;
        }
        //3. Peek
        public int Peek()
        {
            if (Top == null)
            {
                Console.WriteLine("The STack Is EMpty");
                return 0;
            }
            return Top.Value;
        }
        //4. IsEmpty
        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            return false;
        }
        //5. IsFull
        // Can implement tis if we have another property Total size of stack and tracking count       
         
        //6. Print
        public void Print()
        {
            if (Top == null)
            {
                Console.WriteLine("The STack Is EMpty");
                return;
            }
            Node curr= Top;
            while(curr!=null){
                Console.Write(curr.Value);
                Console.Write(" --> ");
                curr=curr.Next;
            }
            Console.WriteLine();

        }


    }
}