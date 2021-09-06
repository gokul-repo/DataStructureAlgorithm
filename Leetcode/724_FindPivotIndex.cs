namespace DataStructureAlgorithm.Leetcode
{
    //724. Find Pivot Index
    //https://leetcode.com/problems/find-pivot-index/
    public class FindPivotIndex
    {
        //Time - O(n)
        //Space - O(1)
        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            for (int j = 0; j < nums.Length; j++)
            {
                if (leftSum == sum - leftSum - nums[j])
                {
                    return j;
                }
                else
                {
                    leftSum = leftSum + nums[j];
                }
            }
            return -1;
        }

    }
}