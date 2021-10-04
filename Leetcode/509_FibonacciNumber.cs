using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //509. Fibonacci Number
    //https://leetcode.com/problems/fibonacci-number/
    public class FibonacciNumber
    {
        //Recursion
        public int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);

        }

        //Recursion with Memoization
        //Top Down with Memoization
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        public int Fib1(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else if (myDict.ContainsKey(n))
            {
                return myDict[n];
            }
            else
            {
                int sum = Fib1(n - 1) + Fib1(n - 2);
                myDict.Add(n, sum);
                return sum;
            }
        }

        //DP
        //Bottom up with Tabulation
        public int Fib2(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int[] cache = new int[n + 1];
            cache[0] = 0;
            cache[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                cache[i] = cache[i - 1] + cache[i - 2];
            }
            return cache[n];
        }

        //Iterative Bottom UP with no tabulation
        public int Fib3(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int current = 0;
            int prev1 = 1;
            int prev2 = 0;
            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }
            return current;
        }

    }
}