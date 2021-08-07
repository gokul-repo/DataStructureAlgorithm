namespace DataStructureAlgorithm.Leetcode
{
    //374. Guess Number Higher or Lower
    //https://leetcode.com/problems/guess-number-higher-or-lower/
    public class GuessNumberHigherLower
    {
        public class Solution //: GuessGame
        {
            public int GuessNumber(int n)
            {
                int l = 1;
                int r = n;
                while (l <= r)
                {
                    int mid = l + (r - l) / 2;
                    //LC specific function call;
                    //int pivot = guess(mid);
                    int pivot=1;
                    if (pivot == -1)
                    {
                        r = mid - 1;
                    }
                    else if (pivot == 1)
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                return -1;

            }
        }

    }
}