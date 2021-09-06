using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //744. Find Smallest Letter Greater Than Target
    //https://leetcode.com/problems/find-smallest-letter-greater-than-target/
    public class FindSmallestLetterGreaterThanTarget
    {
        //Using HashSet
        //Time - O(n)
        //Space - O(1) - The max size of hashset can be 26
        public char NextGreatestLetter(char[] letters, char target)
        {
            HashSet<char> mySet = new HashSet<char>();
            foreach (var item in letters)
            {
                mySet.Add(item);
            }
            while (true)
            {
                target++;
                if (target > 'z')
                {
                    target = 'a';
                }
                if (mySet.Contains(target))
                {
                    return target;
                }
            }
        }
        // Linear Scan
        //Time - O(n)
        //Space - O(1)
        public char NextGreatestLetter2(char[] letters, char target) {
        foreach(var item in letters){
            if (item>target){
                return item;
            }
        }
        return letters[0];
    }
    //Using binary search 
    public char NextGreatestLetter3(char[] letters, char target) {
        int l =0;
        int r= letters.Length;
        while(l<r){
            int mid =l+(r-l)/2;
            var val = letters[mid];
            if(val<= target){
                l=mid+1;
            }else{
                r=mid;
            }
        }
        return letters[l%letters.Length];
            
    }

    }
}