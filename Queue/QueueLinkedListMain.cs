using System;

namespace DataStructureAlgorithm.Queue
{
    public class QueueLinkedListMain
    {
        //1. Enqueue
        //2. DeQueue
        //3. IsEmpty
        //4. IsFull
        //5. First
        //6. Last
        //7. Print

        //TO DO :
        //1. Implement Circular Queue using Array again for practice
        
         static void main(string[] args)
        {
            QueueLinkedList queueArray= new QueueLinkedList();         
            queueArray.Print();
            queueArray.Dequeue();
            queueArray.Enqueue(10);
            queueArray.Enqueue(20);
            queueArray.Enqueue(30);
            queueArray.Enqueue(40);         
            queueArray.Print();
            Console.WriteLine("Removed Element is {0}",queueArray.Dequeue());
            queueArray.Print();
            Console.WriteLine("Removed Element is {0}",queueArray.Dequeue());
            queueArray.Print();
        }   
    }
}