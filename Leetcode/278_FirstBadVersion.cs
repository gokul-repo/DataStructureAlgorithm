namespace DataStructureAlgorithm.Leetcode
{
    //278. First Bad Version
    //https://leetcode.com/problems/first-bad-version/
    public class FirstBadVersion
    {
        public bool IsBadVersion(int x)
        {
            return true;
        }
        //Using Template 1
        public int FirstBadVersion1(int n)
        {
            int l = 1;
            int r = n;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (IsBadVersion(mid))
                {
                    if (!IsBadVersion(mid - 1))
                    {
                        return mid;
                    }
                    else
                    {
                        r = mid - 1;
                    }
                }
                else
                {
                    l = mid + 1;
                }
            }
            return -1;
        }

        //Using Template 2
        public int FirstBadVersion2(int n)
        {
            int l = 1;
            int r = n;
            while (l < r)
            {
                int mid = l + (r - l) / 2;
                if (IsBadVersion(mid))
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