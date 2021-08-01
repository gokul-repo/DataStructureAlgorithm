using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //225. Implement Stack using Queues
    //https://leetcode.com/problems/implement-stack-using-queues/
    public class ImplementStackusingQueues
    {

    }
    public class MyStack
    {
        Queue<int> myQueue1;
        Queue<int> myQueue2;
        int rear = -1;
        /** Initialize your data structure here. */
        public MyStack()
        {
            myQueue1 = new Queue<int>();
            myQueue2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            myQueue1.Enqueue(x);
            rear = x;
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (Empty())
            {
                return -1;
            }
            int top;
            while (myQueue1.Count > 1)
            {
                rear = myQueue1.Dequeue();
                myQueue2.Enqueue(rear);
            }
            top = myQueue1.Dequeue();
            while (myQueue2.Count != 0)
            {
                myQueue1.Enqueue(myQueue2.Dequeue());
            }
            return top;
        }

        /** Get the top element. */
        public int Top()
        {
            return rear;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return myQueue1.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}