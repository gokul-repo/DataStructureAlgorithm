namespace DataStructureAlgorithm.Leetcode
{
    //26.Remove Duplicates from Sorted Array
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/

    public class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}