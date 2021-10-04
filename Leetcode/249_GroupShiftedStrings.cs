using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //249. Group Shifted Strings
    //https://leetcode.com/problems/group-shifted-strings/
    public class GroupShiftedStrings
    {
        public void main()
        {
            string[] strings = new string[] { "abc", "bcd", "acef", "xyz", "az", "ba", "a", "z" };
            GroupShiftedStrings groupShiftedStrings = new GroupShiftedStrings();
            var result = groupShiftedStrings.GroupStrings(strings);
        }

        public IList<IList<string>> GroupStrings(string[] strings)
        {
            List<IList<string>> output = new List<IList<string>>();            
            Dictionary<string,List<string>> myDict = new Dictionary<string, List<string>>();
            foreach(var s in strings){
                byte a = (byte)('a');
                byte offset = (byte)(s[0]-a);
                string key="";
                for(int i=0;i<s.Length;i++){
                    char c = (char)(s[i]-offset);
                    if((byte)c < a){
                        c = (char)((byte)c + 26);
                    }
                    key += c;
                }
                if(!myDict.ContainsKey(key)){
                    myDict.Add(key,new List<string>(){s});
                }else{
                    myDict[key].Add(s);
                }

            }

            foreach(var item in myDict){
                output.Add(item.Value);
            }
            return output;

        }

    }
}