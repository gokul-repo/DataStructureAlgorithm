using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //49. Group Anagrams
    //https://leetcode.com/problems/group-anagrams/
    public class GroupAnagrams
    {
        //Time - O(n.KlogK)
        //Space -  O(n.K)
        public IList<IList<string>> GroupAnagrams1(string[] strs)
        {
            List<IList<string>> output = new List<IList<string>>();
            Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
            foreach (var s in strs)
            {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                string t = new string(chars);
                if (myDict.ContainsKey(t))
                {
                    var currList = myDict[t];
                    currList.Add(s);
                    myDict[t] = currList;

                }
                else
                {
                    List<string> newList = new List<string>();
                    newList.Add(s);
                    myDict.Add(t, newList);
                }
            }
            foreach (var item in myDict)
            {
                output.Add(item.Value);
            }
            return output;
        }

    }
}