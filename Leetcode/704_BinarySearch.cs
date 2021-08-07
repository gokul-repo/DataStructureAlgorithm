namespace DataStructureAlgorithm.Leetcode
{
    //704. Binary Search
    //https://leetcode.com/problems/binary-search/
    public class BinarySearch
    {
        //NOTE :
        // The general mid formula works fine. but it will fail for MAx values so the different mid formula need to be used
        //Recursive
        public int Search(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            return helper(nums, target, l, r);
        }
        public int helper(int[] nums, int target, int l, int r)
        {
            int mid = (l + r) / 2;

            if (l > r)
            {
                return -1;
            }
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (target < nums[mid])
            {
                return helper(nums, target, l, mid - 1);
            }
            else
            {
                return helper(nums, target, mid + 1, r);
            }
            //return -1;
        }
        public int SearchIterative(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                //NOTE THE MID FORMULA
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (target < nums[mid])
                {
                    r = mid - 1;
                }
                else if (target > nums[mid])
                {
                    l = mid + 1;
                }
            }
            return -1;
        }

    }
}