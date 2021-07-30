using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //346. Moving Average from Data Stream
    //https://leetcode.com/problems/moving-average-from-data-stream/
    public class MovingAveragefromDataStream
    {

    }
    //Using List
    //Time O(N) n - length of the window
    //Space O(m) m - size of list
    public class MovingAverageList
    {
        List<int> myList = new List<int>();
        int Size;
        /** Initialize your data structure here. */
        public MovingAverageList(int size)
        {
            Size = size;
        }

        public double Next(int val)
        {
            myList.Add(val);
            int sum = 0;
            int i;
            for (i = Math.Max(0, myList.Count - Size); i < myList.Count; i++)
            {
                sum = sum + myList[i];
            }
            return sum * 1.0 / Math.Min(myList.Count, Size); ;


        }
    }
    //Using Double ended queue Linked List
    //Time O(1) 
    //Space O(N) n - length of the window

    public class MovingAverageLL
    {
        System.Collections.Generic.LinkedList<int> myList = new System.Collections.Generic.LinkedList<int>();
        int Size;
        int Sum;
        int Count;
        /** Initialize your data structure here. */
        public MovingAverageLL(int size)
        {
            Size = size;
        }

        public double Next(int val)
        {
            myList.AddLast(val);
            Count++;
            if(Count > Size){
                Sum =Sum - myList.First.Value;
                myList.RemoveFirst();
                Count--;
            }
            Sum=Sum+val;            
            return Sum * 1.0 / Math.Min(myList.Count, Size); ;


        }
    }

    public class MovingAverageQ
    {
        System.Collections.Generic.Queue<int> myList = new System.Collections.Generic.Queue<int>();
        int Size;
        int Sum;

        /** Initialize your data structure here. */
        public MovingAverageQ(int size)
        {
            myList = new Queue<int>(size);
            Size = size;
        }

        public double Next(int val)
        {
            if(myList.Count ==Size){
                Sum=Sum-myList.Dequeue();
            }
            myList.Enqueue(val) ;
            Sum=Sum+val;
            return Sum*1.0 /myList.Count;
        }
    }
}