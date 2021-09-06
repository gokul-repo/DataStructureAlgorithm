namespace DataStructureAlgorithm.Leetcode
{
    //747. Largest Number At Least Twice of Others
    //https://leetcode.com/problems/largest-number-at-least-twice-of-others/
    public class LargestNumberAtLeastTwiceofOthers
    {

        // 2 Pass
        // Time  - O(n)
        // Space - O(1)

        public int DominantIndex(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int MaxIndex = 0;
            int currMax = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > currMax)
                {
                    currMax = nums[i];
                    MaxIndex = i;
                }
            }
            currMax = -1;
            int secondMax = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] > currMax && j != MaxIndex)
                {
                    currMax = nums[j];
                    secondMax = j;
                }
            }
            if (nums[MaxIndex] >= 2 * nums[secondMax])
            {
                return MaxIndex;
            }
            return -1;

        }

        // 1 Pass
        // Time  - O(n)
        // Space - O(1)
        public int DominantIndex1(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int max = -1;
            int secondMax = -1;
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    secondMax = max;
                    max = nums[i];
                    index = i;
                }
                else if (nums[i] > secondMax)
                {
                    secondMax = nums[i];
                }
            }

            return max >= 2 * secondMax ? index : -1;

        }

    }
}