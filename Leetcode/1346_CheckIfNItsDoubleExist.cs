using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //1346. Check If N and Its Double Exist
    //https://leetcode.com/problems/check-if-n-and-its-double-exist/
    public class CheckIfNItsDoubleExist
    {
        //O(n^2)
        public bool CheckIfExist(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == 2 * arr[j] && i != j)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //O(n)
        public bool CheckIfExist_hash(int[] arr)
        {
            int n = arr.Length;
            HashSet<int> myHash = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (myHash.Contains(2 * arr[i]) || (arr[i] % 2 == 0 && myHash.Contains(arr[i] / 2)))
                {
                    return true;
                }
                myHash.Add(arr[i]);
            }
            return false;
        }

    }
}