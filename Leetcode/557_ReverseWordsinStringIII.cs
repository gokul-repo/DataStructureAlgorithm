using System.Text;

namespace DataStructureAlgorithm.Leetcode
{
    //557. Reverse Words in a String III
    //https://leetcode.com/problems/reverse-words-in-a-string-iii/
    public class ReverseWordsinStringIII
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int n = s.Length;
            int start = 0;
            int end = 0;
            while (start < n)
            {
                while (end < n && s[end] != ' ')
                {
                    end++;
                }
                reverse(sb, start, end - 1);
                end++;
                start = end;
            }
            return sb.ToString();
        }
        public void reverse(StringBuilder s, int left, int right)
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