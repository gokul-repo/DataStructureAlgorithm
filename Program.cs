using System;
using DataStructureAlgorithm.BinarySearchTree;


namespace DataStructureAlgorithm
{
    internal class Program
    {
        //1. Search Iterative
        //2. Search Recursion
        //3. Insert Iterative
        //4. Insert Recursion
        //5. Inorder Traversal
        //6. Inorder Predecessor
        //7. Inorder Successor

        //To DO :
        //8. Delete Recursive
        //9. Create from Post Order
        static void Main(string[] args)
        {     
            BinarySearchTree.BinarySearchTree myBT = new BinarySearchTree.BinarySearchTree();

            myBT.InsertIterative(myBT.Root,10);
            myBT.InsertIterative(myBT.Root,5);
            myBT.InsertIterative(myBT.Root,20);
            myBT.InsertIterative(myBT.Root,8);
            myBT.InsertIterative(myBT.Root,30);
            myBT.inOrder(myBT.Root);
            Console.WriteLine("Search - {0}",myBT.SearchIterative(myBT.Root, 10));
            Console.WriteLine("Search - {0}",myBT.SearchRecursive(myBT.Root, 5));
            Console.WriteLine("Search - {0}",myBT.SearchIterative(myBT.Root, 40));
            Console.WriteLine("Search - {0}",myBT.SearchRecursive(myBT.Root, 50));

            myBT.InsertRecursive(myBT.Root,40);
            myBT.InsertRecursive(myBT.Root,50);
            myBT.InsertRecursive(myBT.Root,9);
            myBT.InsertRecursive(myBT.Root,2);
            myBT.InsertRecursive(myBT.Root,110);
             myBT.inOrder(myBT.Root);

            Console.WriteLine("------------Successor/Predecessor----------");
             BinarySearchTree.BinarySearchTree myBT2 = new BinarySearchTree.BinarySearchTree();
             
            myBT2.Root= myBT2.InsertRecursive(myBT2.Root,30);
            myBT2.InsertRecursive(myBT2.Root,20);
            myBT2.InsertRecursive(myBT2.Root,40);
            myBT2.InsertRecursive(myBT2.Root,10);
            myBT2.InsertRecursive(myBT2.Root,25);
            myBT2.InsertRecursive(myBT2.Root,35);
            myBT2.InsertRecursive(myBT2.Root,45);
             myBT2.inOrder(myBT2.Root);

             var pre= myBT2.InOrderPredecessor(myBT2.Root);
             var succ= myBT2.InOrderSuccessor(myBT2.Root);
             Console.WriteLine("Predecessor - {0}", pre.Value);
             Console.WriteLine("Successor - {0}",succ.Value);


        }
    }
}
