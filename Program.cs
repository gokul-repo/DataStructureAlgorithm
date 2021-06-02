using System;
using DataStructureAlgorithm.BinaryTree;


namespace DataStructureAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
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
