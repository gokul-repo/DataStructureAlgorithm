namespace DataStructureAlgorithm.Leetcode
{
    //33. Search in Rotated Sorted Array
    //https://leetcode.com/problems/search-in-rotated-sorted-array/
    public class SearchinRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int n = nums.Length;
            if (n == 1)
            {
                return nums[0] == target ? 0 : -1;
            }
            int rotating_index = findRotatingIndex(nums, target);
            if (nums[rotating_index] == target)
            {
                return rotating_index;
            }
            if (rotating_index == 0)
            {
                return search(nums, target, 0, n - 1);
            }
            else if (target >= nums[0])
            {
                return search(nums, target, 0, rotating_index - 1);
            }
            else
            {
                return search(nums, target, rotating_index, n - 1);
            }
        }
        public int search(int[] nums, int target, int l, int r)
        {
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target > nums[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return -1;
        }
        public int findRotatingIndex(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            if (nums[l] < nums[r])
            {
                return 0;
            }
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    return mid + 1;
                }
                if (nums[l] <= nums[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return 0;
        }

        //One pass Binary search
        public int Search1(int[] nums, int target)
        {
            int n = nums.Length;
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] >= nums[l])
                {
                    if (target < nums[mid] && target >= nums[l])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[r])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
            }
            return -1;
        }

    }
}