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
        //2. Insert - Alternate method
        //2.a Left Rotate
        //2.b Right Rotate
        //3. Delete - Abdul way [Alternate way is simmilar to insert]   

       //To DO - Reimplement insert and delete for practice
        
        
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
           
            myAVL.Root=null;

            Console.WriteLine("-----------------------Method 2 INSERT--------------------");
            AVL2 myAVL2 = new AVL2();        
             
            myAVL2.Root = myAVL.Insert(myAVL2.Root,10);
            myAVL2.Insert(myAVL2.Root,5);
            myAVL2.Insert(myAVL2.Root,2);
            myAVL2.inOrder(myAVL2.Root);
            Console.WriteLine("LL Rotation :");
            Console.WriteLine("New Root is {0}",myAVL2.Root.Value);    

              myAVL2.Root=null;

            myAVL2.Root = myAVL2.Insert(myAVL2.Root,2);
            myAVL2.Insert(myAVL2.Root,5);
            myAVL2.Insert(myAVL2.Root,10);
            myAVL2.inOrder(myAVL2.Root);
            Console.WriteLine("RR Rotation :");
            Console.WriteLine("New Root is {0}",myAVL2.Root.Value);

             myAVL2.Root=null;

            myAVL2.Root = myAVL2.Insert(myAVL2.Root,10);
            myAVL2.Insert(myAVL2.Root,2);
            myAVL2.Insert(myAVL2.Root,5);
            myAVL2.inOrder(myAVL2.Root);
            Console.WriteLine("LR Rotation :");
            Console.WriteLine("New Root is {0}",myAVL2.Root.Value);

             myAVL2.Root=null;

            myAVL2.Root = myAVL2.Insert(myAVL2.Root,10);
            myAVL2.Insert(myAVL2.Root,5);
            myAVL2.Insert(myAVL2.Root,2);
            myAVL2.inOrder(myAVL2.Root);
            Console.WriteLine("RL Rotation :");
            Console.WriteLine("New Root is {0}",myAVL2.Root.Value);

            
            Console.WriteLine("-----------------------Delet - Abdul Badri way--------------------");
            AVLTree myAVL3 = new AVLTree();        
            myAVL3.Root = myAVL3.Insert(myAVL3.Root,10);
            myAVL3.Insert(myAVL3.Root,20);
            myAVL3.Insert(myAVL3.Root,30);
            myAVL3.Insert(myAVL3.Root,25);
            myAVL3.Insert(myAVL3.Root,28);
            myAVL3.Insert(myAVL3.Root,27);
            myAVL3.Insert(myAVL3.Root,5);            
            Console.WriteLine("Before Delete :");
            myAVL3.inOrder(myAVL3.Root);
            myAVL3.Delete(myAVL3.Root,28);
            Console.WriteLine("After Delete :");
            myAVL3.inOrder(myAVL3.Root);
            

        }
    }
}
