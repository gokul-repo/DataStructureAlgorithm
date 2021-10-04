using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //170. Two Sum III - Data structure design
    //https://leetcode.com/problems/two-sum-iii-data-structure-design/
    public class TwoSumIII
    {
        //Using two pinter - simmilar to LC167
        List<int> numbers;
        bool sorted;

        /** Initialize your data structure here. */
        public TwoSumIII()
        {
            numbers = new List<int>();
            sorted = false;
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            numbers.Add(number);
            sorted = false;

        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            if (sorted == false)
            {
                numbers.Sort();
                sorted = true;
            }
            int low = 0;
            int high = numbers.Count - 1;
            while (low < high)
            {
                int sum = numbers[low] + numbers[high];
                if (sum > value)
                {
                    high--;
                }
                else if (sum < value)
                {
                    low++;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class TwoSum1
    {

        Dictionary<int, int> myMap;

        /** Initialize your data structure here. */
        public TwoSum1()
        {
            myMap = new Dictionary<int, int>();
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (myMap.ContainsKey(number))
            {
                myMap[number] = myMap[number] + 1;
            }
            else
            {
                myMap.Add(number, 1);
            }
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            foreach (var item in myMap)
            {
                int complement = value - item.Key;
                if (complement != item.Key)
                {
                    if (myMap.ContainsKey(complement))
                    {
                        return true;
                    }

                }
                else
                {
                    if (myMap[complement] > 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}