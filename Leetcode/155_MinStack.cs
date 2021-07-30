using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //155. Min Stack
    //https://leetcode.com/problems/min-stack/

    // Approach 1 
    //Time - O(1)
    //Space - O(n)
    public class MinStack
    {
        public Stack<int[]> myStack;
        /** initialize your data structure here. */
        public MinStack()
        {
            myStack = new Stack<int[]>();
        }

        public void Push(int val)
        {
            if (myStack.Count == 0)
            {
                myStack.Push(new int[] { val, val });
                return;
            }
            int currMin = GetMin();
            myStack.Push(new int[] { val, Math.Min(currMin, val) });
        }

        public void Pop()
        {
            if (myStack.Count == 0)
            {
                return;
            }
            myStack.Pop();

        }

        public int Top()
        {
            if (myStack.Count == 0)
            {
                return -1;
            }
            int[] value = myStack.Peek();
            return value[0];
        }

        public int GetMin()
        {
            if (myStack.Count == 0)
            {
                return -1;
            }
            int[] value = myStack.Peek();
            return value[1];
        }
    }

    //Using Two Stack

    public class MinStackTwoStack
    {

        public Stack<int> mainStack;
        public Stack<int> minStack;
        /** initialize your data structure here. */
        public MinStackTwoStack()
        {
            mainStack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            if (mainStack.Count == 0)
            {
                mainStack.Push(val);
                minStack.Push(val);
                return;
            }
            mainStack.Push(val);
            int currMin = GetMin();
            if (val <= currMin)
            {
                minStack.Push(val);
            }
        }

        public void Pop()
        {
            if (mainStack.Count == 0)
            {
                return;
            }
            int curVal = Top();
            int min = GetMin();
            if (curVal == min)
            {
                minStack.Pop();
            }
            mainStack.Pop();

        }

        public int Top()
        {
            if (mainStack.Count == 0)
            {
                return -1;
            }
            return mainStack.Peek();
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
            {
                return -1;
            }
            return minStack.Peek();
        }
    }
}