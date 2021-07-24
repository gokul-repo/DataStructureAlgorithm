namespace DataStructureAlgorithm.Leetcode
{
    //27. Remove Element
    //https://leetcode.com/problems/remove-element/
    //Simillar Questions
        //Remove Duplicates from Sorted Array
        //Remove Linked List Elements
        //Move Zeroes

    public class RemoveElement
    {
        //2 point
        public int RemoveElementSolution(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }

        //2 pointer - reducing number of unwanted swaps.
        public int RemoveElementOptimum(int[] nums, int val)
        {
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }

    }
}