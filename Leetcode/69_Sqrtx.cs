namespace DataStructureAlgorithm.Leetcode
{
    //69. Sqrt(x)
    //https://leetcode.com/problems/sqrtx/
    public class Sqrtx
    {
        //Binary Search
        public int MySqrt(int x)
        {
            if (x < 2)
            {
                return x;
            }
            int l = 2;
            int r = x / 2;
            double num;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                num = (double)mid * mid;
                if (num == x)
                {
                    return mid;
                }
                else if (num > x)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return r;
        }
    }
}