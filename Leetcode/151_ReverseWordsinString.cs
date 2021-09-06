using System;
using System.Text;

namespace DataStructureAlgorithm.Leetcode
{
    //151. Reverse Words in a String
    //https://leetcode.com/problems/reverse-words-in-a-string/
    public class ReverseWordsinString
    {
        //Approach 1 - Split and reverse
        //Time - O(n)
        //Space - O(n)
        public string ReverseWords(string s)
        {
            s.Trim();
            var stringArray = s.Split(" ");
            string output = "";
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                if (stringArray[i] != "")
                {
                    Console.WriteLine(stringArray[i]);
                    output = output + " " + stringArray[i].Trim();
                }
            }
            return output.Trim();
        }

        //Approach 2    Reverse whole string and then each word
        //Time - O(n)
        //Space -O(n)
        public string ReverseWords2(string s)
        {
            StringBuilder sb = trimSpaces(s);
            reverse(sb, 0, sb.Length - 1);
            reverseWord(sb);
            return sb.ToString();
        }

        public StringBuilder trimSpaces(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left <= right && s[left] == ' ')
            {
                left++;
            }
            while (left <= right && s[right] == ' ')
            {
                right--;
            }
            StringBuilder sb = new StringBuilder();
            while (left <= right)
            {
                if (s[left] != ' ')
                {
                    sb.Append(s[left]);
                }
                else
                {
                    if (sb[sb.Length - 1] != ' ')
                    {
                        sb.Append(s[left]);
                    }
                }
                left++;
            }
            return sb;
        }

        public void reverse(StringBuilder sb, int left, int right)
        {
            while (left < right)
            {
                char temp = sb[left];
                sb[left] = sb[right];
                sb[right] = temp;
                left++;
                right--;
            }
        }

        public void reverseWord(StringBuilder sb)
        {
            int n = sb.Length;
            int start = 0;
            int end = 0;
            while (start < n)
            {
                while (end < n && sb[end] != ' ')
                {
                    end++;
                }
                reverse(sb, start, end - 1);
                start = end + 1;
                end++;
            }
        }
    }
}