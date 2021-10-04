using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //347. Top K Frequent Elements
    //https://leetcode.com/problems/top-k-frequent-elements/
    public class TopKFrequentElements
    {
        //Brute force with Hash Table
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (myDict.ContainsKey(item))
                {
                    myDict[item]++;
                }
                else
                {
                    myDict.Add(item, 1);
                }
            }
            List<int> output = new List<int>();
            for (int i = 0; i < k; i++)
            {
                int maxCount = 0;
                int max = 0;
                foreach (var item in myDict)
                {
                    if (item.Value > maxCount)
                    {
                        max = item.Key;
                        maxCount = item.Value;
                    }
                }
                output.Add(max);
                myDict[max] = 0;
            }
            return output.ToArray();
        }

    }
}