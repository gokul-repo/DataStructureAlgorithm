using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //387. First Unique Character in a String
    //https://leetcode.com/problems/first-unique-character-in-a-string/
    public class FirstUniqueCharacterinaString
    {
        //Time - O(n)
        //Space - O(1) - xoz we only have 26 alphabets
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (myDict.ContainsKey(c))
                {
                    myDict[c] = myDict[c] + 1;
                }
                else
                {
                    myDict.Add(c, 1);
                }
            }
            for (int j = 0; j < s.Length; j++)
            {
                char d = s[j];
                if (myDict.ContainsKey(d) && myDict[d] == 1)
                {
                    return j;
                }
            }
            return -1;
        }
    }
}