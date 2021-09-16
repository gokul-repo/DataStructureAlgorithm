using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //205. Isomorphic Strings
    //https://leetcode.com/problems/isomorphic-strings/
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> StoT = new Dictionary<char, char>();
            Dictionary<char, char> TtoS = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c1 = s[i];
                char c2 = t[i];
                if (!StoT.ContainsKey(c1) && !TtoS.ContainsKey(c2))
                {
                    StoT.Add(c1, c2);
                    TtoS.Add(c2, c1);
                }
                else if (StoT.ContainsKey(c1) && StoT[c1] != c2)
                {
                    return false;
                }
                else if (TtoS.ContainsKey(c2) && TtoS[c2] != c1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}