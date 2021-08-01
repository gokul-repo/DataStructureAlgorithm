using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //232. Implement Queue using Stacks
    //https://leetcode.com/problems/implement-queue-using-stacks/
    public class ImplementQueueusingStacks
    {

    }

    //Approach 1
    public class MyQueue1
    {

        public Stack<int> myStack1;
        public Stack<int> myStack2;
        int front;
        /** Initialize your data structure here. */
        public MyQueue1()
        {
            myStack1 = new Stack<int>();
            myStack2 = new Stack<int>();
            front = -1;
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (Empty())
            {
                front = x;
            }
            myStack1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (Empty())
            {
                return -1;
            }
            int top;
            while (myStack1.Count != 0)
            {
                myStack2.Push(myStack1.Pop());
            }
            top = myStack2.Pop();
            if (myStack2.Count != 0)
            {
                front = myStack2.Peek();
            }
            while (myStack2.Count != 0)
            {
                myStack1.Push(myStack2.Pop());
            }
            return top;
        }

        /** Get the front element. */
        public int Peek()
        {
            return front;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return myStack1.Count == 0;
        }
    }

    //Amortized time complexity
    public class MyQueue
    {
        int front;
        Stack<int> myStack1;
        Stack<int> myStack2;


        /** Initialize your data structure here. */
        public MyQueue()
        {
            myStack1 = new Stack<int>();
            myStack2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            if (myStack1.Count == 0)
            {
                front = x;
            }
            myStack1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (myStack2.Count != 0)
            {
                return myStack2.Pop();
            }
            while (myStack1.Count != 0)
            {
                myStack2.Push(myStack1.Pop());
            }
            return myStack2.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (myStack2.Count != 0)
            {
                return myStack2.Peek();
            }
            return front;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return myStack1.Count == 0 && myStack2.Count == 0;

        }
    }
}