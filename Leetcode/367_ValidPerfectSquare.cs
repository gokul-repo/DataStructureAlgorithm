namespace DataStructureAlgorithm.Leetcode
{
    //367. Valid Perfect Square
    //https://leetcode.com/problems/valid-perfect-square/
    public class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num < 2)
            {
                return true;
            }
            long l = 2;
            long r = num / 2;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                var val = mid * mid;
                if (val == num)
                {
                    return true;
                }
                if (val > num)
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }

            }
            return false;
        }

    }
}