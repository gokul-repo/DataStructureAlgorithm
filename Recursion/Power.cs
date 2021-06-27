using System;

namespace DataStructureAlgorithm.Recursion
{
    public class Power
    {
        public void main()
        {
            Console.WriteLine("Power");
            Console.WriteLine("Recursion");
            int output = PowerRecursion(2, 5);
            Console.WriteLine(output);
            Console.WriteLine("Improved Recursion");
            output = PowerRecursionImproved(2, 5);
            Console.WriteLine(output);
            Console.WriteLine("Iterative");
            output = PowerIterative(2, 5);
            Console.WriteLine(output);
        }

        public int PowerRecursion(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            return PowerRecursion(x, y - 1) * x;
        }

        public int PowerRecursionImproved(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            if (y % 2 == 0)
            {
                return PowerRecursionImproved(x * x, y / 2);
            }
            else
            {
                return x * PowerRecursionImproved(x * x, (y - 1) / 2);
            }
        }

        public int PowerIterative(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            int output = x;
            for (int i = 1; i < y; i++)
            {
                output = output * x;
            }
            return output;
        }
    }
}