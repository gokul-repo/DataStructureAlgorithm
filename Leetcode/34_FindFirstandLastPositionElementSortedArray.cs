namespace DataStructureAlgorithm.Leetcode
{
    //34. Find First and Last Position of Element in Sorted Array
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    public class FindFirstandLastPositionElementSortedArray
    {
        //Brute force method
        //O(n)
        public int[] SearchRangeBruteForce(int[] nums, int target)
        {
            int[] output = new int[2];
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == target)
                {
                    output[0] = i;
                    int j = i;
                    while (j < n && nums[j] == target)
                    {
                        output[1] = j;
                        j++;
                    }
                    return output;
                }
            }
            return new int[] { -1, -1 };
        }

        //Binary Search - FIrst attempt
        //The if statements can be reduced.

        public int[] SearchRangeBinarySearch(int[] nums, int target)
        {
            int firstIndex = FindFirst(nums, target);
            if (firstIndex == -1)
            {
                return new int[] { -1, -1 };
            }
            int lastIndex = FindLast(nums, target);
            return new int[] { firstIndex, lastIndex };
        }

        public int FindFirst(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    if (nums[mid] == nums[l])
                    {
                        return l;
                    }
                    if (nums[mid - 1] == target)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                else
                {
                    if (target < nums[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
            }
            return -1;
        }
        public int FindLast(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (nums[mid] == target)
                {
                    if (nums[mid] == nums[r])
                    {
                        return r;
                    }
                    if (nums[mid + 1] == target)
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                else
                {
                    if (target < nums[mid])
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
            }
            return -1;
        }

    }
}