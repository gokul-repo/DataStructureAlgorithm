using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //202. Happy Number
    //https://leetcode.com/problems/happy-number/
    public class HappyNumber
    {
        //Approach 1 - Using HAshSet
        public int getNext(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int digit = n % 10;
                sum = sum + digit * digit;
                n = n / 10;
            }
            return sum;
        }
        public bool IsHappy(int n)
        {
            HashSet<int> myHashSet = new HashSet<int>();

            while (n != 1 && !myHashSet.Contains(n))
            {
                myHashSet.Add(n);
                n = getNext(n);
            }
            return n == 1;
        }

        //Approach 2 - Floyds Detect cycle algorithm
        public bool IsHappy2(int n)
        {

            int slowRun = n;
            int fastRun = getNext(n);
            while (fastRun != 1 && slowRun != fastRun)
            {
                slowRun = getNext(slowRun);
                fastRun = getNext(getNext(fastRun));
            }
            return fastRun == 1;

        }

    }
}