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
        //8. Delete Recursive
        //9. Height
        //10. 

        //To DO :
        //1. Delete Recursive (Redo)
        //2. Create from Pre Order
        static void Main(string[] args)
        {
            BinarySearchTree.BinarySearchTree myBT = new BinarySearchTree.BinarySearchTree();

            myBT.InsertIterative(myBT.Root, 10);
            myBT.InsertIterative(myBT.Root, 5);
            myBT.InsertIterative(myBT.Root, 20);
            myBT.InsertIterative(myBT.Root, 8);
            myBT.InsertIterative(myBT.Root, 30);
            myBT.inOrder(myBT.Root);
            Console.WriteLine("Search - {0}", myBT.SearchIterative(myBT.Root, 10));
            Console.WriteLine("Search - {0}", myBT.SearchRecursive(myBT.Root, 5));
            Console.WriteLine("Search - {0}", myBT.SearchIterative(myBT.Root, 40));
            Console.WriteLine("Search - {0}", myBT.SearchRecursive(myBT.Root, 50));

            myBT.InsertRecursive(myBT.Root, 40);
            myBT.InsertRecursive(myBT.Root, 50);
            myBT.InsertRecursive(myBT.Root, 9);
            myBT.InsertRecursive(myBT.Root, 2);
            myBT.InsertRecursive(myBT.Root, 110);
            myBT.inOrder(myBT.Root);

            Console.WriteLine("------------Successor/Predecessor----------");
            BinarySearchTree.BinarySearchTree myBT2 = new BinarySearchTree.BinarySearchTree();

            myBT2.Root = myBT2.InsertRecursive(myBT2.Root, 30);
            myBT2.InsertRecursive(myBT2.Root, 20);
            myBT2.InsertRecursive(myBT2.Root, 40);
            myBT2.InsertRecursive(myBT2.Root, 10);
            myBT2.InsertRecursive(myBT2.Root, 25);
            myBT2.InsertRecursive(myBT2.Root, 35);
            myBT2.InsertRecursive(myBT2.Root, 45);
            myBT2.inOrder(myBT2.Root);

            var pre = myBT2.InOrderPredecessor(myBT2.Root);
            var succ = myBT2.InOrderSuccessor(myBT2.Root);
            Console.WriteLine("Predecessor - {0}", pre.Value);
            Console.WriteLine("Successor - {0}", succ.Value);

            Console.WriteLine("------------Delete----------");
            BinarySearchTree.BinarySearchTree myBT3 = new BinarySearchTree.BinarySearchTree();
            myBT3.Root = myBT3.InsertRecursive(myBT3.Root, 10);
            myBT3.InsertRecursive(myBT3.Root, 5);
            myBT3.InsertRecursive(myBT3.Root, 20);
            myBT3.InsertRecursive(myBT3.Root, 8);
            myBT3.InsertRecursive(myBT3.Root, 30);
            Console.WriteLine("Before: ");
            myBT3.inOrder(myBT3.Root);
            Console.WriteLine("AFter: ");
            myBT3.Delete(myBT3.Root, 10);
            myBT3.inOrder(myBT3.Root);

            Console.WriteLine("------------Delete2----------");
            BinarySearchTree.BinarySearchTree myBT4 = new BinarySearchTree.BinarySearchTree();
            myBT4.Root = myBT4.InsertRecursive(myBT4.Root, 50);
            myBT4.InsertRecursive(myBT4.Root, 10);
            myBT4.InsertRecursive(myBT4.Root, 40);
            myBT4.InsertRecursive(myBT4.Root, 20);
            myBT4.InsertRecursive(myBT4.Root, 30);
            Console.WriteLine("Before: ");
            myBT4.inOrder(myBT4.Root);
            Console.WriteLine("AFter: ");
            myBT4.Delete(myBT4.Root, 50);
            myBT4.inOrder(myBT4.Root);


        }
    }
}
