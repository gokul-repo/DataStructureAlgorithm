using System;

namespace DataStructureAlgorithm.Utilities
{
    public static class Utilities
    {
        public static void PrintArray(int[] list)
        {
            foreach (var item in list)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }

}