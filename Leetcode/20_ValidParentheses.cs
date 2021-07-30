using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //20. Valid Parentheses
    //https://leetcode.com/problems/valid-parentheses/
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length <= 1)
            {
                return false;
            }
            Dictionary<char, char> brackets = new Dictionary<char, char>(){
            {'}','{'},
            {']','['},
            {')','('},
        };
            Stack<char> myStack = new Stack<char>();
            foreach (char c in s)
            {
                if (!brackets.ContainsKey(c))
                {
                    myStack.Push(c);
                    continue;
                }
                if (myStack.Count == 0 || myStack.Pop() != brackets[c])
                {
                    return false;
                }
            }
            return myStack.Count == 0;
        }

    }
}