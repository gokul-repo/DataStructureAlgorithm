using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //771. Jewels and Stones
    //https://leetcode.com/problems/jewels-and-stones/
    public class JewelsandStones
    {
        //Time - O(n + m)
        //Space - O(m)
        public int NumJewelsInStones(string jewels, string stones)
        {
            HashSet<char> mySet = new HashSet<char>();
            for (int i = 0; i < jewels.Length; i++)
            {
                mySet.Add(jewels[i]);
            }
            int count = 0;
            for (int j = 0; j < stones.Length; j++)
            {
                if (mySet.Contains(stones[j]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}