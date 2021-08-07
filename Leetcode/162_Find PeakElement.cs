namespace DataStructureAlgorithm.Leetcode
{
    //162. Find Peak Element
    //https://leetcode.com/problems/find-peak-element/
    public class FindPeakElement
    {
        //Approach 1 
        // Time - O(n)
        //Space - O(1)
        public int FindPeakElementIterative(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    return i;
                }
            }
            return nums.Length - 1;

        }
        //Approach - Bianry Search
        // Time - O(log n)
        //Space - O(1)
        public int FindPeakElementBinarySearch(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    r = mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return l;

        }
    }
}