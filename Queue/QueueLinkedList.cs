using System;

namespace DataStructureAlgorithm.Queue
{
    public class QueueLinkedList
    {
        public Node Head;
        public Node Tail;

        public QueueLinkedList(){
            Head= null;
            Tail=null;
        }

        //Enqueue
        public void Enqueue(int val){
            Node newNode = new Node(val);
            if (Head == null){
                Head=newNode;
                Tail=newNode;
            }else if( Head == Tail){
                Head.Next=newNode;
                Tail=newNode;
            }else{
                Tail.Next=newNode;
                Tail=newNode;
            }
            return;
        }

         //Dequeue
        public int Dequeue(){            
            if (Head == null){
                Console.WriteLine("Queue is EMpty");
                return 0;
            }else if( Head == Tail){
                int val = Head.Value;
                Head=null;
                Tail=null;
                return val;
            }else{
                int val = Head.Value;
                Head=Head.Next;
                return val;
            }
           
        }

        //Print

        public void Print(){
            if (Head == null){
                Console.WriteLine("Queue is empty");
                return;                
            }
            Node curr = Head;
            while(curr!=null){
                Console.Write("{0}  -->  ",curr.Value);
                curr=curr.Next;
            }
            Console.WriteLine();
            return;
        }
    }
}