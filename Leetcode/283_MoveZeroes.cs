namespace DataStructureAlgorithm.Leetcode
{
    //283. Move Zeroes
    //https://leetcode.com/problems/move-zeroes/
    public class MoveZeroes
    {
        public void MoveZeroes1(int[] arr)
        {
            int n = arr.Length;
            int i = 0;
            for (int j = 1; j < n; j++)
            {
                if (arr[i] != 0)
                {
                    i++;
                    continue;
                }
                if (arr[i] == 0 && arr[j] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
                if (arr[i] == 0 && arr[j] == 0)
                {
                    continue;
                }

            }
        }

    }
}