using System;

namespace DataStructureAlgorithm.CircularLinkedList
{
    public class CircularLL
    {
        public Node Head;

        public CircularLL()
        {
            Head=null;
        }
        //Add at Head
        public void AddAtHead(int val){
            Node newNode = new Node(val);
            if (Head == null){                
                Head=newNode;
                Head.Next=Head;
                return;
            }
            Node curr = Head;            
            while(curr.Next!=Head){
                curr=curr.Next;
            }
            curr.Next=newNode;
            newNode.Next=Head;
            Head=newNode;
        }

        //Add at Tail
                public void AddAtTail(int val){
            Node newNode = new Node(val);
            if (Head == null){                
                Head=newNode;
                Head.Next=Head;
                return;
            }
            Node curr = Head;            
            while(curr.Next!=Head){
                curr=curr.Next;
            }
            curr.Next=newNode;
            newNode.Next=Head;            
        }

        //Add at Index
        //Assumption that idx within range;
        //DId not implement when Index is out of the range - This can be done if we have a count property in our LL class.

        public void AddAtIndex(int val,int idx){
            Node newNode = new Node(val);
            if (Head == null){                
                Head=newNode;
                Head.Next=Head;
                return;
            }
            if ( idx == 0){
                AddAtHead(val);
                return;
            }
            Node curr = Head; 
            for(int i =0 ;i<idx-1;i++){
                curr=curr.Next;
            }  
            newNode.Next=curr.Next;         
            curr.Next=newNode;                    
        }

        //Delete at Head
        public void DeleteAtHead(){           
            if (Head == null){                
               Console.WriteLine("The List is EMpty");
               return;
            }
            if (Head.Next == Head){
                Head=null;
                return;
            }
            Node curr = Head.Next;            
            while(curr.Next!=Head){
                curr=curr.Next;
            }
            curr.Next=Head.Next;            
            Head=curr.Next;
        }        

         //Delete at Tail
        public void DeleteATail(){           
            if (Head == null){                
               Console.WriteLine("The List is EMpty");
               return;
            }
            if (Head.Next == Head){
                Head=null;
                return;
            }
            Node prev = Head;
            Node curr = Head.Next;            
            while(curr.Next!=Head){
                curr=curr.Next;
                prev=prev.Next;
            }
           prev.Next=curr.Next;
           curr.Next=null;
        }
        //Delete at Index
        //Assumption that idx within range;
        //DId not implement when Index is out of the range - This can be done if we have a count property in our LL class.

        public void DeleteAtIndex(int idx){            
            if (Head == null){                
               Console.WriteLine("The List is EMpty");
               return;
            }
            if ( idx == 0){
                DeleteAtHead();
                return;
            }
            Node curr = Head;
            Node prev=null; 
            for(int i =0 ;i<idx;i++){
                prev=curr;
                curr=curr.Next;
            }  
            prev.Next=curr.Next;         
            curr.Next=null;                    
        }


        //Print
        public void Print(){
            if(Head == null){
                Console.WriteLine("Lists is Empty");
                return;
            }
            Node curr=Head;
            do{
                Console.Write("{0}  -->  ",curr.Value);
                curr=curr.Next;
            }
            while(curr!= Head);
            Console.WriteLine();
        }
    
    }
}