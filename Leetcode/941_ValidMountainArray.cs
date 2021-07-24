namespace DataStructureAlgorithm.Leetcode
{
    //941. Valid Mountain Array
    //https://leetcode.com/problems/valid-mountain-array/
    public class ValidMountainArray
    {
        //SIngle Pass
        public bool ValidMountainArrayOnePass(int[] arr)
        {
            int n = arr.Length;
            if (n <= 2)
            {
                return false;
            }
            int i = 0;
            while (i + 1 < n && arr[i] < arr[i + 1])
            {
                i++;
            }
            if (i == 0 || i == n - 1)
            {
                return false;
            }
            while (i + 1 < n && arr[i] > arr[i + 1])
            {
                i++;
            }
            return i == n - 1;
        }
        //Two Pass
        public bool ValidMountainArrayTwoPass(int[] arr)
        {
            int n = arr.Length;
            if (n <= 2)
            {
                return false;
            }
            int i = 0;
            int j = n - 1;
            while (i + 1 < n && arr[i] < arr[i + 1])
            {
                i++;
            }
            while (j - 1 > 0 && arr[j] < arr[j - 1])
            {
                j--;
            }

            return i > 0 && j < n - 1 && i == j;

        }

    }
}