using System;

namespace DataStructureAlgorithm.Queue
{
    public class QueueArray
    {
        public static int Size = 10;
        public int First;
        public int Last;

        public int[] QueueArr =new int[Size];

        public QueueArray(){
            First=0;
            Last=0;
        }

        //EnQueue
        public void Enqueue(int val){
            if (Last>=Size){
                Console.WriteLine("Queue is Full");
                return;
            }            
            QueueArr[Last]=val;
            Last++;            
        }

        //DeQueue - Takes O(n) time as invloves shifting all elements - Better performance using circular queue
         public int Dequeue(){
             if (Last == 0){
                 Console.WriteLine("Queue is Empty");
                 return 0;
             }
             int val = QueueArr[First];
             for (int i = 0;i<=Last;i++){
                 QueueArr[i]=QueueArr[i+1];
             }             
             Last--;
             return val;                       
        }
        //Print Queue
        public void Print(){
            if(First == Last){
                Console.WriteLine("Queue is Empty");
                return;
            }
            for(int i=0;i<Last;i++){
                Console.Write("{0} --> ",QueueArr[i]);
            }
            Console.WriteLine();
        }

        //IsEmpty
        public bool IsEmpty(){
            if(First==Last){
                return true;
            }
            return false;
        }

        //IsFull
        public bool IsFull(){
            if (Last>=Size-1){
                return true;
            }
            return false;
        }

        //First
        public int FirstInQueue(){
            return QueueArr[First];
        }

        //Last
         public int LastInQueue(){
            return QueueArr[Last-1];
        }

    }
}