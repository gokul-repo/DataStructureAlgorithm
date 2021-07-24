using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //448. Find All Numbers Disappeared in an Array
    //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/


    public class FindAllNumbersDisappearedArray
    {
        //Time O(n)
        //Space O(n) - due to HashSet
        public IList<int> FindDisappearedNumbersHashSet(int[] nums)
        {
            int n = nums.Length;
            HashSet<int> mySet = new HashSet<int>(nums);
            for (int i = 0; i < n; i++)
            {
                mySet.Add(nums[i]);
            }
            List<int> result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (!mySet.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        //Time O(n)
        //Space O(1) - Inplace 
        //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/discuss/92958/c%2B%2B-solution-O(1)-space
        public IList<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length;
        for(int i=0;i<n;i++){
            int temp = nums[i];
            temp= temp>0?temp:-temp;
            if(nums[temp-1]>0){
                nums[temp-1]*=-1;
            }
        }
        List<int> result = new List<int>();
        for(int i=0;i<n;i++){
            if(nums[i]>0){
                result.Add(i+1);
            }            
        }
        return result;      
    }
    }
}