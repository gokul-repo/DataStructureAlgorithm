namespace DataStructureAlgorithm.Leetcode
{
    //186. Reverse Words in a String II
    //https://leetcode.com/problems/reverse-words-in-a-string-ii/
    public class ReverseWordsStringII
    {
        public void ReverseWords(char[] s)
        {
            //Reverse entire array
            int left = 0;
            int right = s.Length - 1;
            reverse(s, left, right);

            //reverse each word
            int n = s.Length;
            int start = 0;
            int end = 0;
            while (start < n)
            {
                while (end < n && s[end] != ' ')
                {
                    end++;
                }
                reverse(s, start, end - 1);
                end++;
                start = end;
            }

        }

        public void reverse(char[] s, int left, int right)
        {
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
        }
    }
}