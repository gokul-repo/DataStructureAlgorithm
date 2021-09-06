namespace DataStructureAlgorithm.Leetcode
{
    //189. Rotate Array
    //https://leetcode.com/problems/rotate-array/
    public class RotateArray
    {
        //Brute force
        //Time - O(n * K)
        //Space - O(n=1)

        public void Rotate1(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int last = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = last;
            }
        }
        //Approach 2 - using extra space
        //Time - O(n)
        //Space - O(n)
        public void Rotate2(int[] nums, int k)
        {
            int[] a = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                a[(i + k) % nums.Length] = nums[i];
            }
            for (int j = 0; j < nums.Length; j++)
            {
                nums[j] = a[j];
            }

        }

        //Approach 3 - Reverse 
        //Time - O(n)
        //Space - O(1)
        public void Rotate3(int[] nums, int k)
        {
            k = k % nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);
        }

        public void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}