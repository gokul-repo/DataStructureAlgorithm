using System;

namespace DataStructureAlgorithm.Queue
{
    public class CircularQueueArray
    {
        public int Front;
        public int End;
        public static int Size = 5;
        public int[] CQueueArray = new int[Size];

        public CircularQueueArray()
        {
            Front = -1;
            End = -1;
        }

        public void EnQueue(int val)
        {
            //Check Queue is Full
            if ((End + 1) % Size == Front)
            {
                Console.WriteLine("Queue is FULL");
            }
            else if (Front == -1) //Insert FIrst element
            {
                Front = 0;
                End = 0;
                CQueueArray[Front] = val;
            }
            else
            {
                End = (End + 1) % Size;
                CQueueArray[End] = val;
            }
            return;
        }

        public int DeQueue()
        {
            //Check Queue is Empty
            if (Front == -1)
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }
            int val = CQueueArray[Front];
            CQueueArray[Front] = -1;
            if (Front == End)// Remove the only element 
            {
                Front = -1;
                End = -1;
            }
            else
            {
                Front = (Front + 1) % Size;
            }
            return val;
        }

        public void Print()
        {
            if (Front == -1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            if(End >= Front){
                for (int i =Front ;i <=End;i++){
                    Console.WriteLine(CQueueArray[i]);
                }
            }else{
                for( int i=Front ; i< Size;i++){
                    Console.WriteLine(CQueueArray[i]);
                }
                for( int i =0;i <=End ;i++){
                     Console.WriteLine(CQueueArray[i]);
                }
            }

        }
    }

}