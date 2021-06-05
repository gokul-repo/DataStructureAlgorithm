using System;
using DataStructureAlgorithm.AVL;


namespace DataStructureAlgorithm
{
    internal class Program
    {
        //1. Insert - Abdul Bari method
        //1.a NodeHeight
        //1.b Balance Factor
        //1.c LL Rotate
        //1.d LR Rotate
        //1.e RR Rotate
        //1.f RL Rotate
     

        //To DO :
        //2. Insert - Alternate method
        //3. Delete
        
        
        static void Main(string[] args)
        {
            
            AVLTree myAVL = new AVLTree();            
            myAVL.Root = myAVL.Insert(myAVL.Root,10);
            myAVL.Insert(myAVL.Root,5);
            myAVL.Insert(myAVL.Root,2);
            myAVL.inOrder(myAVL.Root);
            Console.WriteLine("LL Rotation :");
            Console.WriteLine("New Root is {0}",myAVL.Root.Value);

            myAVL.Root=null;

            myAVL.Root = myAVL.Insert(myAVL.Root,2);
            myAVL.Insert(myAVL.Root,5);
            myAVL.Insert(myAVL.Root,10);
            myAVL.inOrder(myAVL.Root);
            Console.WriteLine("RR Rotation :");
            Console.WriteLine("New Root is {0}",myAVL.Root.Value);

             myAVL.Root=null;

            myAVL.Root = myAVL.Insert(myAVL.Root,10);
            myAVL.Insert(myAVL.Root,2);
            myAVL.Insert(myAVL.Root,5);
            myAVL.inOrder(myAVL.Root);
            Console.WriteLine("LR Rotation :");
            Console.WriteLine("New Root is {0}",myAVL.Root.Value);

             myAVL.Root=null;

            myAVL.Root = myAVL.Insert(myAVL.Root,10);
            myAVL.Insert(myAVL.Root,5);
            myAVL.Insert(myAVL.Root,2);
            myAVL.inOrder(myAVL.Root);
            Console.WriteLine("RL Rotation :");
            Console.WriteLine("New Root is {0}",myAVL.Root.Value);

        }
    }
}
