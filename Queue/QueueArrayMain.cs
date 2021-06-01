using System;

namespace DataStructureAlgorithm.Queue
{
    public class QueueArrayMain
    {
        //1. Enqueue
        //2. DeQueue
        //3. IsEmpty
        //4. IsFull
        //5. First
        //6. Last
        //7. Print

        //static void Main(string[] args)
        static void main(string[] args)
        {
            QueueArray queueArray = new QueueArray();
            Console.WriteLine(queueArray.IsEmpty());
            Console.WriteLine(queueArray.IsFull());
            queueArray.Print();
            queueArray.Enqueue(10);
            queueArray.Enqueue(20);
            queueArray.Enqueue(30);
            queueArray.Enqueue(40);
            Console.WriteLine(queueArray.FirstInQueue());
            Console.WriteLine(queueArray.LastInQueue());
            queueArray.Print();
            Console.WriteLine("Removed Element is {0}", queueArray.Dequeue());
            queueArray.Print();
            Console.WriteLine("Removed Element is {0}", queueArray.Dequeue());
            queueArray.Print();
            Console.WriteLine(queueArray.IsEmpty());
            queueArray.Enqueue(50);
            queueArray.Enqueue(60);
            queueArray.Enqueue(70);
            queueArray.Enqueue(80);
            queueArray.Enqueue(90);
            queueArray.Enqueue(100);
            queueArray.Enqueue(110);
            queueArray.Enqueue(120);
            Console.WriteLine(queueArray.IsFull());
            queueArray.Print();
            queueArray.Enqueue(130);
        }
    }
}