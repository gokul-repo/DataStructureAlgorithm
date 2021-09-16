using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //599. Minimum Index Sum of Two Lists
    //https://leetcode.com/problems/minimum-index-sum-of-two-lists/
    public class MinimumIndexSumofTwoLists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> output = new List<string>();
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                myDict.Add(list1[i], i);
            }
            int min = int.MaxValue;
            int sum = 0;
            for (int j = 0; j < list2.Length && j <= min; j++)
            {
                if (myDict.ContainsKey(list2[j]))
                {
                    sum = j + myDict[list2[j]];
                    if (sum < min)
                    {
                        output.Clear();
                        output.Add(list2[j]);
                        min = sum;
                    }
                    else if (sum == min)
                    {
                        output.Add(list2[j]);
                    }

                }
            }
            return output.ToArray();
        }

    }
}