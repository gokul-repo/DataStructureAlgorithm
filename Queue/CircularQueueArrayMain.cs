using System;

namespace DataStructureAlgorithm.Queue
{
    public class CircularQueueArrayMain
    {
        static void main(string[] args)
        {
            CircularQueueArray queueArray = new CircularQueueArray();
            queueArray.EnQueue(10);
            queueArray.EnQueue(20);
            queueArray.EnQueue(30);
            queueArray.EnQueue(40);
            queueArray.EnQueue(50);
            queueArray.Print();
            queueArray.EnQueue(60);
            Console.WriteLine("The Removed Element is {0}", queueArray.DeQueue());
            queueArray.Print();
            queueArray.EnQueue(60);
            queueArray.Print();
        }
    }
}