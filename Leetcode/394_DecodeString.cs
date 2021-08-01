using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //394. Decode String
    //https://leetcode.com/problems/decode-string/
    public class DecodeString
    {

        // Attempt 1 
        public string DecodeString1(string s)
        {
            int length = s.Length;
            Stack<char> myStack = new Stack<char>();
            for (int i = 0; i < length; i++)
            {
                if (s[i] != ']')
                {
                    myStack.Push(s[i]);
                    continue;
                }
                else if (s[i] == ']')
                {
                    char temp = myStack.Pop();
                    string currBlock = "";
                    while (temp != '[')
                    {
                        currBlock = currBlock + temp.ToString();
                        temp = myStack.Pop();
                    }
                    string num = "";
                    while (myStack.Count != 0 && Char.IsNumber(myStack.Peek()))
                    {
                        num = num + myStack.Pop().ToString();
                    }
                    char[] charArray = num.ToCharArray();
                    Array.Reverse(charArray);
                    string temp1 = new string(charArray);
                    Console.WriteLine(temp1);
                    //int n=5;  
                    int n = Int32.Parse(temp1.ToString());
                    string outStr = "";
                    for (int j = 0; j < n; j++)
                    {
                        outStr = outStr + currBlock;
                    }
                    for (int k = outStr.Length - 1; k >= 0; k--)
                    {
                        myStack.Push(outStr[k]);
                    }
                }
            }
            char[] charsList = new char[myStack.Count];
            int p = 0;
            while (myStack.Count != 0)
            {
                charsList[p] = myStack.Pop();
                p++;
            }
            Array.Reverse(charsList);
            return new string(charsList);
        }
    }
}