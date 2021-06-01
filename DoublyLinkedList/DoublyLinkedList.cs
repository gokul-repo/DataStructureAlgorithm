using System;

namespace DataStructureAlgorithm.DoublyLinkedList
{
    public class DoublyLL
    {
        public Node Head;
        public DoublyLL()
        {
            Head = null;
        }

        //Add at Head
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Head.Prev = newNode;
            newNode.Next = Head;
            Head = newNode;
        }

        //Add at Tail
        public void AddAtTail(int val)
        {
            Node newNode = new Node(val);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            newNode.Prev = curr;
            curr.Next = newNode;
        }

        //Add at index
        public void AddAtIndex(int val, int index)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            Node newNode = new Node(val);
            Node temp = Head;
            for (int i = 0; i < index - 1; i++)
            {
                if (temp == null)
                {
                    Console.WriteLine("Index greater than List size");
                    return;
                }
                temp = temp.Next;
            }
            if (temp.Next == null)
            {
                AddAtTail(val);
                return;
            }
            newNode.Prev = temp;
            newNode.Next = temp.Next;
            temp.Next.Prev = newNode;
            temp.Next = newNode;
        }

        //Delete at head
        public void DeleteAtHead()
        {
            if (Head == null)
            {
                return;
            }
            Head = Head.Next;
            Head.Prev= null;
        }
        //delete at tail
        public void DeleteAtTail()
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Next == null)
            {
                Head = null;
                return;
            }
            Node prev = Head;
            Node curr = Head.Next;
            while (curr.Next != null)
            {
                prev = prev.Next;
                curr = curr.Next;
            }
            prev.Next.Prev=null;
            prev.Next = null;
            
        }
        //delete at index 
        public void DeleteAtIndex(int index)
        {
            if (index == 0)
            {
                this.DeleteAtHead();
                return;
            }
            Node prev = Head;
            Node curr = Head.Next;
            for (int i = 0; i < index - 1; i++)
            {
                if (curr == null)
                {
                    Console.WriteLine("Index greater than List size");
                    return;
                }
                prev = prev.Next;
                curr = curr.Next;
            }
            if (curr == null)
            {
                Console.WriteLine("Index greater than List size");
                return;
            }

             if (curr.Next == null)
            {
                DeleteAtTail();
                return;
            }
            prev.Next=curr.Next;
            curr.Prev=null;
            curr.Next.Prev=prev;
            curr.Next=null;

        }


        //Print
        public void Print()
        {
            if (Head == null)
            {
                Console.WriteLine("List is EMpty");
                return;
            }
            Node curr = Head;
            while (curr != null)
            {
                Console.Write("{0}  -->  ", curr.Value);
                curr = curr.Next;
            }
            Console.WriteLine();
        }
    }
}