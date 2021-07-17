using System;

namespace DataStructureAlgorithm.Algortihms
{
    //https://www.youtube.com/watch?v=34l1kTIQCIA&ab_channel=TECHDOSE
    //https://www.geeksforgeeks.org/subset-sum-problem-dp-25/
    //TODO : https://www.geeksforgeeks.org/subset-sum-backtracking-4/
    public class SumofSubset
    {
        public void SumofSubset_Main()
        {
            int[] set = new int[] { 1, 2, 2, 3 };
            int sum = 6;
            Console.WriteLine("------------using Recursion---------");
            Console.WriteLine(IsSumOfSubSetRecursive(set, sum, set.Length));
            Console.WriteLine("------------using DP---------");
            Console.WriteLine(IsSumOfSubSetDP(set, sum, set.Length));

        }

        public bool IsSumOfSubSetRecursive(int[] set, int sum, int n)
        {
            if (sum == 0)
            {
                return true;
            }
            //n==0 is we run out of the list
            if (sum != 0 && n == 0)
            {
                return false;
            }

            if (set[n - 1] > sum)
            {
                //this scenario is when last element is greater than the sum itself
                return IsSumOfSubSetRecursive(set, sum, n - 1);
            }
            return IsSumOfSubSetRecursive(set, sum, n - 1) || IsSumOfSubSetRecursive(set, sum - set[n - 1], n - 1);
        }

        public bool IsSumOfSubSetDP(int[] set, int sum, int n)
        {
            bool[,] dp = new bool[set.Length + 1, sum + 1];

            for (int i = 0; i < set.Length + 1; i++)
            {
                //sum of 0 is possible for all elements so making it true
                dp[i, 0] = true;
            }
            for (int i = 1; i <= sum; i++)
            {
                //sum of anything greater than 0 is not possible without any elements so making it false
                dp[0, i] = false;
            }

            for (int i = 1; i < set.Length + 1; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (j < set[i - 1])
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    if (j >= set[i - 1])
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i - 1, j - set[i - 1]];
                    }
                }
            }

            for (int i = 0; i < set.Length + 1; i++)
            {
                for (int j = 0; j <= sum; j++)
                {
                    Console.Write(dp[i, j]);
                    Console.Write("    ");
                }
                Console.WriteLine();
            }
            return dp[set.Length, sum];


        }
    }
}