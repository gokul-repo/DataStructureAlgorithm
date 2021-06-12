using System;
using DataStructureAlgorithm.Hashing;


namespace DataStructureAlgorithm
{
    internal class Program
    {
        //1. Hashing -  Chaining
        //2. Linear Probing
        //3. Quadratic Probing (Did not implemet as its similar to Linear - Just change i to i*i)
        //4. Double Hashing

        static void Main(string[] args)
        {
            // Chaining      
            Console.WriteLine("------Chaining---------");
            HashTable newHT = new HashTable(10);
            newHT.Insert(0);
            newHT.Insert(1);
            newHT.Insert(2);
            newHT.Insert(3);
            newHT.Insert(4);
            newHT.Insert(55);
            newHT.Insert(6);
            newHT.Insert(7);
            newHT.Insert(8);
            newHT.Insert(9);     
             newHT.Insert(15);
            newHT.Insert(35);
            newHT.Insert(25);
            newHT.Insert(95);
            newHT.Insert(45);
            newHT.Insert(5);
            Console.WriteLine(newHT.Search(0));             
            Console.WriteLine(newHT.Search(99));
            Console.WriteLine(newHT.Search(5));
            Console.WriteLine(newHT.Search(25));
            Console.WriteLine(newHT.Search(95));
            Console.WriteLine(newHT.Search(100));

            //Linear Probing
            Console.WriteLine("------Linear Probing---------");
            HashTableLinearProbing myHT = new HashTableLinearProbing(10);
            myHT.Insert(10);
            myHT.Insert(11);
            myHT.Insert(5);
            myHT.Insert(15);
            myHT.Insert(26);

            Console.WriteLine(myHT.Search(10));             
            Console.WriteLine(myHT.Search(15));
            Console.WriteLine(myHT.Search(26));
            Console.WriteLine(myHT.Search(20));

            //Double Hashing
            Console.WriteLine("------Double Hashing---------");

             HashTableDoubleHashing myHT1 = new HashTableDoubleHashing(10);
            myHT1.Insert(5);
            myHT1.Insert(25);
            myHT1.Insert(15);
            myHT1.Insert(35);
            myHT1.Insert(95);

            Console.WriteLine(myHT1.Search(5));             
            Console.WriteLine(myHT1.Search(15));
            Console.WriteLine(myHT1.Search(95));
            Console.WriteLine(myHT1.Search(20));           

        }
    }
}
