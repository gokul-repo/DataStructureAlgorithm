namespace DataStructureAlgorithm.Leetcode
{
    //702. Search in a Sorted Array of Unknown Size
    //https://leetcode.com/problems/search-in-a-sorted-array-of-unknown-size/

    public class SearchSortedArrayofUnknownSize
    {
        public int Search(ArrayReader reader, int target)
        {
            int l = 0;
            int r = 10000;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                int val = reader.Get(mid);
                if (val == target)
                {
                    return mid;
                }
                if (val == int.MaxValue)
                {
                    r = mid - 1;
                }
                else
                {
                    if (target > val)
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

        //Determine the search limit first
        //Then so Binary search
        public int Search1(ArrayReader reader, int target)
        {
            //first find boundaries
            int l = 0;
            int r = 1;
            while (reader.Get(r) < target)
            {
                l = r;
                r = r * 2;
            }
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                int val = reader.Get(mid);
                if (val == target)
                {
                    return mid;
                }
                if (target > val)
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
    }


    public class ArrayReader
    {
        public int Get(int index)
        {
            return 1;
        }
    }
}