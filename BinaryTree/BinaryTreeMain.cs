using System;

namespace DataStructureAlgorithm.BinaryTree
{
    public class BinaryTreeMain
    {
        static void main(string[] args)
        {
            BinaryTrees myBT = new BinaryTrees();
            myBT.Create();
            Console.WriteLine("--------IN ORDER----------");
            myBT.inOrder(myBT.RootNode);
            Console.WriteLine("--------PRE ORDER----------");
            myBT.preOrder(myBT.RootNode);
            Console.WriteLine("--------POST ORDER----------");
            myBT.postOrder(myBT.RootNode);
            Console.WriteLine("--------Level ORDER----------");
            myBT.LevelOrder(myBT.RootNode);
        }
    }
}