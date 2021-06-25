using System;

namespace DataStructureAlgorithm.Sorting
{
    public static class Utilities
    {
         public static void Print(int[] list){
            foreach(var item in list){
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}