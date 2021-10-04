using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //70. Climbing Stairs
    //https://leetcode.com/problems/climbing-stairs/
    public class ClimbingStairs
    {
        //Recursion
        public int ClimbStairs1(int n)
        {
            if (n == 1 || n == 2)
            {
                return n;
            }
            return ClimbStairs1(n - 1) + ClimbStairs1(n - 2);
        }

        //Recursion with memoization
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        public int ClimbStairs(int n)
        {
            if (n == 1 || n == 2)
            {
                return n;
            }
            else if (myDict.ContainsKey(n))
            {
                return myDict[n];
            }
            else
            {
                int sum = ClimbStairs(n - 1) + ClimbStairs(n - 2);
                myDict.Add(n, sum);
                return sum;
            }

        }

    }
}