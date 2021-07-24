namespace DataStructureAlgorithm.Leetcode
{
    //905. Sort Array By Parity
    //https://leetcode.com/problems/sort-array-by-parity/
    public class SortArrayByParity
    {
        public int[] SortArrayByParity1(int[] nums)
        {
            int n = nums.Length;
            int i = 0;
            int j = n - 1;
            while (i < j)
            {
                if (nums[i] % 2 != 0 && nums[j] % 2 == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j--;
                }
                if (nums[i] % 2 == 0)
                {
                    i++;
                }
                if (nums[j] % 2 != 0)
                {
                    j--;
                }
            }
            return nums;
        }

    }
}