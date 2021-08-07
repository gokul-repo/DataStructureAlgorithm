namespace DataStructureAlgorithm.Leetcode
{
    //153. Find Minimum in Rotated Sorted Array
    //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    public class FindMinimuminRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            if (nums[l] < nums[r])
            {
                return nums[l];
            }
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }
                if (nums[mid - 1] > nums[mid])
                {
                    return nums[mid];
                }
                if (nums[mid] > nums[0])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }
            return nums[l];
        }

    }
}