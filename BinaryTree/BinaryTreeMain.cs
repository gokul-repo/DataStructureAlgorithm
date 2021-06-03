using System;

namespace DataStructureAlgorithm.BinaryTree
{
    public class BinaryTreeMain
    {
        //1. Creat a Binary tree from user input
        //2. In Order Traversal - Recursive
        //3. In Order Traversal - Iterative
        //4. Pre Order Traversal - Recursive
        //5. Pre Order Traversal - Iterative
        //6. Post Order Traversal - Iterative
        //7. Count of all Nodes
        //8. Count of Leaf Nodes
        //8. Count of Non Leaf Nodes
        //9. Height

        //To DO :
        //1. Creat a BT using inorder and post order
        //2. Creat a BT using inorder and pre order
        //3. Leetcode - Binary Tree
        static void main(string[] args)
        {
            BinaryTrees myBT = new BinaryTrees();
            myBT.Create();
            Console.WriteLine("--------IN ORDER----------");
            myBT.inOrder(myBT.RootNode);
            Console.WriteLine("--------IN ORDER iterative----------");
            myBT.InOrderIterative(myBT.RootNode);
            Console.WriteLine("--------PRE ORDER----------");
            myBT.preOrder(myBT.RootNode);
            Console.WriteLine("--------PRE ORDER Iterative----------");
            myBT.PreOrderIterative(myBT.RootNode);
            Console.WriteLine("--------POST ORDER----------");
            myBT.postOrder(myBT.RootNode);
            Console.WriteLine("--------Level ORDER----------");
            myBT.LevelOrder(myBT.RootNode);

            Console.WriteLine("Total number of Node {0}", myBT.Count(myBT.RootNode));
            Console.WriteLine("Total number of Leaf Node {0}", myBT.CountLeaf(myBT.RootNode));
            Console.WriteLine("Total number of Non Leaf Node {0}", myBT.CountNonLeaf(myBT.RootNode));
            Console.WriteLine("Height is {0}", myBT.Height(myBT.RootNode));
        }
    }
}