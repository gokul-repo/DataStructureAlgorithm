using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAlgorithm.Leetcode
{
    //414. Third Maximum Number
    //https://leetcode.com/problems/third-maximum-number/
    public class ThirdMaximumNumber
    {
        //O(n log n) solution
        //using sort
        public int ThirdMax_sort(int[] nums)
        {
            int n = nums.Length;
            Array.Sort(nums);
            int count = 1;

            for (int i = n - 1; i - 1 >= 0; i--)
            {
                if (nums[i] != nums[i - 1])
                {
                    count++;
                }
                if (count == 3)
                {
                    return nums[i - 1];
                }
            }
            return nums[n - 1];
        }
        // Approach 1 
        //time - O(n)
        //space -O(n) - due to hashset;
        public int ThirdMax(int[] nums)
        {
            int n = nums.Length;
            HashSet<int> mySet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                mySet.Add(nums[i]);
            }
            int maximum = mySet.Max();
            if (mySet.Count < 3)
            {
                return maximum;
            }
            mySet.Remove(maximum);
            maximum = mySet.Max();
            mySet.Remove(maximum);            
            return mySet.Max();
        }

        //Approach 2
        //time - O(n)
        //space -O(1) - coz the hashset will only have 3 items at max...so constant

        public int ThirdMax_HashSet(int[] nums)
        {
            int n = nums.Length;
            HashSet<int> mySet = new HashSet<int>();
            for (int i = 0; i < 3; i++)
            {
                int? max = FinMaximum(nums, mySet);
                if (max == null)
                {
                    return mySet.Max();
                }
                mySet.Add((int)max);
            }
            return mySet.Min();
        }
        public int? FinMaximum(int[] nums, HashSet<int> mySet)
        {
            int? max = null;
            for (int i = 0; i < nums.Length; i++)
            {
                if (mySet.Contains(nums[i]))
                {
                    continue;
                }
                if (max == null || nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        //Approach 3
        //time - O(n) n=butin this approach we are only doin single pass hrough the input array
        //space -O(1)

        public int ThirdMax_maxHashSet(int[] nums)
        {
            int n = nums.Length;
            HashSet<int> mySet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                mySet.Add(nums[i]);
                if (mySet.Count > 3)
                {
                    int min = mySet.Min();
                    mySet.Remove(min);
                }
            }
            if (mySet.Count == 3)
            {
                return mySet.Min();
            }
            return mySet.Max();
        }
    }
}