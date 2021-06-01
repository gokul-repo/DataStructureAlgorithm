using System;

namespace DataStructureAlgorithm.LinkedList
{
    // Single Linked List Implementation Local 
    public class SingleLinkedList
    {
        public Node Head;
        public SingleLinkedList()
        {
            Head = null;
        }

        //Add at head
        public void AddAtHead(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
                return;
            }
            Node newNode = new Node(val);
            newNode.Next = Head;
            Head = newNode;
        }
        //Add at tail
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
                return;
            }
            Node newNode = new Node(val);
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
        //Add at index
        public void AddAtIndex(int val, int index)
        {
            if (index == 0)
            {
                this.AddAtHead(val);
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
            newNode.Next = temp.Next;
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
            prev.Next = curr.Next;
        }
        //Get value at an Index
        public int GetValue(int idx)
        {
            if (Head == null)
            {
                Console.WriteLine("The LL is Empty");
                return -1;
            }
            Node curr = Head;
            for (int i = 0; i < idx; i++)
            {
                if (curr == null)
                {
                    break;
                }
                curr = curr.Next;
            }
            if (curr == null)
            {
                Console.WriteLine("Index out of Range");
                return -1;
            }
            return curr.Value;
        }
        //print node
        public void PrintNodes()
        {
            if (Head == null)
            {
                Console.WriteLine("The LL is Empty");
                return;
            }
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Value);
                Console.Write("-->");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        //Count
        public int Count()
        {
            if (Head == null)
            {
                return 0;
            }
            Node curr = Head;
            int count = 0;
            while (curr != null)
            {
                count++;
                curr = curr.Next;
            }
            return count;
        }
        //Sum
        public int Sum()
        {
            if (Head == null)
            {
                return 0;
            }
            Node curr = Head;
            int sum = 0;
            while (curr != null)
            {
                sum = sum + curr.Value;
                curr = curr.Next;
            }
            return sum;
        }
        //Max
        public int Max()
        {
            if (Head == null)
            {
                return 0;
            }
            Node curr = Head;
            int currMax = 0;
            while (curr != null)
            {
                if (curr.Value > currMax)
                    currMax = curr.Value;
                curr = curr.Next;
            }
            return currMax;
        }

        //Search
        public bool Search(int val)
        {
            if (Head == null)
            {
                return false;
            }
            Node curr = Head;
            while (curr != null)
            {
                if (curr.Value == val)
                    return true;
                curr = curr.Next;
            }
            return false; ;
        }

        //Insert in Sorted LL 
        public void InsertInSort(int val)
        {
            if (Head == null)
            {
                this.AddAtHead(val);
                return;
            }
            Node curr = Head;
            int idx = 0;
            while (curr != null)
            {
                if (curr.Value > val)
                {
                    AddAtIndex(val, idx);
                    return;
                }
                curr = curr.Next;
                idx++;
            }
            AddAtTail(val);
        }

        //Insert in Sorted LL - Two Pointer Approach
        public void InsertInSort2(int val)
        {
            if (Head == null)
            {
                this.AddAtHead(val);
                return;
            }
            Node prev = null;
            Node curr = Head;
            Node newNode = new Node(val);
            while (curr != null)
            {
                if (curr.Value > val)
                {
                    if (prev == null)
                    {
                        newNode.Next = curr;
                        Head = newNode;
                        return;
                    }
                    prev.Next = newNode;
                    newNode.Next = curr;
                    return;
                }
                prev = curr;
                curr = curr.Next;
            }
            this.AddAtTail(val);
        }

        //Is LL Sorted
        public bool IsSorted()
        {
            if (Head == null)
            {
                return true;
            }
            Node prev = Head;
            Node curr = Head.Next;

            while (curr != null)
            {
                if (prev.Value > curr.Value)
                {
                    return false;
                }
                curr = curr.Next;
                prev = prev.Next;
            }
            return true;
        }

        //Remove DUplicated from SOrted LL
        public void RemoveDupesFromSortedLL()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }
            Node prev = Head;
            Node curr = Head.Next;
            while (curr != null)
            {
                if (prev.Value == curr.Value)
                {
                    prev.Next = curr.Next;
                    curr = curr.Next;
                    continue;
                }
                prev = prev.Next;
                curr = curr.Next;
            }
        }
        //Reverse a LL using Sliding pointer
        public void Reverse()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }
            Node curr = Head;
            Node prev = null;
            Node prevPrev = null;
            while (curr != null)
            {
                prevPrev = prev;
                prev = curr;
                curr = curr.Next;
                prev.Next = prevPrev;
            }
            prev.Next = prevPrev;
            Head = prev;
        }

    }
}
