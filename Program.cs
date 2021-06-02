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
            Console.WriteLine("--------PRE ORDER----------");
             myBT.preOrder(myBT.RootNode);
             Console.WriteLine("--------POST ORDER----------");
              myBT.postOrder(myBT.RootNode);
        }
    }
}
