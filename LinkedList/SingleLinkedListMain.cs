

using System;

namespace DataStructureAlgorithm.LinkedList
{
    internal class SingleLinkedListMain
    {
        //1. Add at head
        //2. Add at tail
        //3. Add at index
        //4. Delete at head
        //5. delete at tail
        //6. delete at index
        //7. print node
        //8. print node Recursively
        //9. Get value at an Index
        //10. Count number of nodes
        //11. Max value in LL
        //12. Sum off all values
        //13. Search
        //14. Insert in a Sorted LL
        //15. Insert in a Sorted LL - Two pointer Apporach
        //16. Check if LL is sorted
        //17. Remove Duplicates from Sorted LL
        //18. Reverse a Linked List
        //19. Reverse a Linked List - Recursive
        //20. COncatenate
        //21. Merge sorted LL into a single Sorted LL - NOT IMPLEMENTED YET 
        //22. Detect Loop - SOlved it in another file DetectCycle.cs (Leetcode)


        //To DO :
        //1. Merge Two Sorted LL to One SOrted LL (Leet COde)
        //2. LeetCode - LinkedList
        //3. Abdul Badri - STudent Challenges
        //4. Reverse a Doubly Linked List
        //5. Insert in sorted array- Prabhu code

        //static void Main(string[] args)
        static void main(string[] args)
        {
            Console.WriteLine("-------------Basic Implemnattion---------------");
            SingleLinkedList mySLL = new SingleLinkedList();
            mySLL.AddAtHead(10);
            mySLL.AddAtTail(20);
            mySLL.AddAtHead(5);
            mySLL.AddAtTail(30);
            mySLL.PrintNodes();
            mySLL.AddAtIndex(15, 2);
            mySLL.AddAtIndex(2, 0);
            mySLL.AddAtIndex(40, 6);
            mySLL.AddAtIndex(40, 10);
            mySLL.PrintNodes();
            mySLL.DeleteAtHead();
            mySLL.DeleteAtHead();
            mySLL.DeleteAtTail();
            mySLL.DeleteAtTail();
            mySLL.PrintNodes();
            mySLL.DeleteAtIndex(1);
            mySLL.PrintNodes();
            mySLL.DeleteAtIndex(2);
            mySLL.DeleteAtIndex(100);
            mySLL.PrintNodes();
            Console.WriteLine(mySLL.GetValue(0));
            Console.WriteLine(mySLL.GetValue(1));
            Console.WriteLine(mySLL.GetValue(2));
            Console.WriteLine(mySLL.GetValue(222));
            Console.WriteLine("-------------Print Recursive ---------------------");
            SingleLinkedList mySLL2 = new SingleLinkedList();
            mySLL2.AddAtTail(10);
            mySLL2.AddAtTail(20);
            mySLL2.AddAtTail(30);
            mySLL2.AddAtTail(40);
            mySLL2.AddAtTail(50);
            PrintNodesRecursive(mySLL2.Head);
            Console.WriteLine();
            Console.WriteLine("-------------Count/SUM/MAX ---------------------");
            Console.WriteLine(mySLL2.Count());
            Console.WriteLine(mySLL2.Max());
            Console.WriteLine(mySLL2.Sum());
            Console.WriteLine("-------------Search ---------------------------");
            Console.WriteLine(mySLL2.Search(10));
            Console.WriteLine(mySLL2.Search(40));
            Console.WriteLine(mySLL2.Search(100));
            Console.WriteLine("-------------Insert in Sorted LL ---------------------------");
            mySLL2.InsertInSort(5);
            mySLL2.InsertInSort(15);
            mySLL2.InsertInSort(25);
            mySLL2.InsertInSort(35);
            mySLL2.InsertInSort(55);
            mySLL2.InsertInSort(35);
            mySLL2.PrintNodes();
            Console.WriteLine("-------------Insert in Sorted LL 2 Pointer---------------------------");
            SingleLinkedList mySLL4 = new SingleLinkedList();
            mySLL4.AddAtTail(10);
            mySLL4.AddAtTail(20);
            mySLL4.AddAtTail(30);
            mySLL4.AddAtTail(40);
            mySLL4.AddAtTail(50);
            mySLL4.InsertInSort2(5);
            mySLL4.InsertInSort2(15);
            mySLL4.InsertInSort2(25);
            mySLL4.InsertInSort2(35);
            mySLL4.InsertInSort2(55);
            mySLL4.InsertInSort2(35);
            mySLL4.PrintNodes();
            Console.WriteLine("-------------Is LL Sorted ---------------------------");
            Console.WriteLine(mySLL2.IsSorted());
            SingleLinkedList mySLL3 = new SingleLinkedList();
            mySLL3.AddAtTail(10);
            mySLL3.AddAtTail(20);
            mySLL3.AddAtTail(5);
            Console.WriteLine(mySLL3.IsSorted());
            Console.WriteLine("-------------Remove Duplicates from Sorter LL ---------------------------");
            SingleLinkedList mySLL5 = new SingleLinkedList();
            mySLL5.AddAtTail(10);
            mySLL5.AddAtTail(10);
            SingleLinkedList mySLL6 = new SingleLinkedList();
            mySLL6.AddAtTail(10);
            mySLL6.AddAtTail(20);
            mySLL6.AddAtTail(30);
            mySLL6.AddAtTail(30);
            SingleLinkedList mySLL7 = new SingleLinkedList();
            mySLL7.AddAtTail(10);
            mySLL7.AddAtTail(20);
            mySLL7.AddAtTail(20);
            mySLL7.AddAtTail(20);
            mySLL7.AddAtTail(30);
            Console.WriteLine("BEFORE ----");
            mySLL5.PrintNodes();
            mySLL6.PrintNodes();
            mySLL7.PrintNodes();
            mySLL5.RemoveDupesFromSortedLL();
            mySLL6.RemoveDupesFromSortedLL();
            mySLL7.RemoveDupesFromSortedLL();
            Console.WriteLine("AFTER ----");
            mySLL5.PrintNodes();
            mySLL6.PrintNodes();
            mySLL7.PrintNodes();
            Console.WriteLine("-------------Reverse  ---------------------------");
            Console.WriteLine("BEFORE ----");
            mySLL5.PrintNodes();
            mySLL6.PrintNodes();
            mySLL4.PrintNodes();
            mySLL5.Reverse();
            mySLL6.Reverse();
            mySLL4.Reverse();
            Console.WriteLine("AFTER ----");
            mySLL5.PrintNodes();
            mySLL6.PrintNodes();
            mySLL4.PrintNodes();
            Console.WriteLine("-------------Reverse Recursive  ---------------------------");
            Console.WriteLine("BEFORE ----");
            mySLL5.PrintNodes();
            mySLL6.PrintNodes();
            mySLL4.PrintNodes();
            Console.WriteLine("AFTER ----");
            var sll = ReverseRecursive(mySLL5);
            sll.PrintNodes();
            sll = ReverseRecursive(mySLL6);
            sll.PrintNodes();
            sll = ReverseRecursive(mySLL4);
            sll.PrintNodes();
            Console.WriteLine("-------------CONCATENATE  ---------------------------");
            SingleLinkedList concatSll1 = new SingleLinkedList();
            concatSll1.AddAtTail(10);
            concatSll1.AddAtTail(30);
            concatSll1.AddAtTail(50);
            concatSll1.AddAtTail(70);
            concatSll1.AddAtTail(90);
            SingleLinkedList concatSll2 = new SingleLinkedList();
            concatSll2.AddAtTail(20);
            concatSll2.AddAtTail(40);
            concatSll2.AddAtTail(60);
            concatSll2.AddAtTail(80);
            concatSll2.AddAtTail(100);
            var result = Concatenate(concatSll1, concatSll2);
            result.PrintNodes();
            // Console.WriteLine("-------------Merge  ---------------------------");
            // var resultNode = Merge(concatSll1.Head, concatSll2.Head);
            // result.Head = resultNode;
            // result.PrintNodes();


        }

        //print node Recursively
        public static void PrintNodesRecursive(Node head)
        {
            if (head != null)
            {
                Console.Write(head.Value);
                Console.Write("-->");
                PrintNodesRecursive(head.Next);
            }

        }

        //Reverse node Recursively - CAN BE DONE BETTER
        public static SingleLinkedList ReverseRecursive(SingleLinkedList sll)
        {
            if (sll.Head == null || sll.Head.Next == null)
            {
                return sll;
            }
            SingleLinkedList newSll = new SingleLinkedList();
            newSll = reverseHelper(sll, sll.Head, null);
            return newSll;

        }

        public static SingleLinkedList reverseHelper(SingleLinkedList sll, Node curr, Node prev)
        {
            if (curr != null)
            {
                reverseHelper(sll, curr.Next, curr);
                curr.Next = prev;
            }
            else
            {
                sll.Head = prev;
            }
            return sll;
        }

        //Concatenate two SLL
        public static SingleLinkedList Concatenate(SingleLinkedList sll1, SingleLinkedList sll2)
        {

            if (sll1.Head == null)
                return sll2;
            else if (sll2.Head == null)
                return sll1;
            SingleLinkedList resulSll = new SingleLinkedList();
            resulSll.Head = sll1.Head;
            Node curr = resulSll.Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            curr.Next = sll2.Head;
            return resulSll;
        }

        //Merge  two SLL in sorted way
        // public static Node Merge(Node sll1, Node sll2)
        // {
        //     Node head = new Node(0);
        //     Node dummy = head;
        //     while (sll1 != null && sll2 != null)
        //     {
        //         if (sll1.Value <= sll2.Value)
        //         {
        //             head.Next = sll1;
        //             sll1 = sll1.Next;
        //         }
        //         else
        //         {
        //             head.Next = sll2;
        //             sll2 = sll2.Next;
        //         }
        //         head = head.Next;
        //     }

        //     head.Next = sll1 ?? sll2;

        //     // if (first == null)
        //     //     curr.Next=second;
        //     // else
        //     //     curr.Next=first;            
        //     return dummy.Next;
        // }
    }
}
