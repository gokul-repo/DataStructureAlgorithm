using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //150. Evaluate Reverse Polish Notation
    //https://leetcode.com/problems/evaluate-reverse-polish-notation
    public class EvaluateReversePolishNotation
    {
        //Time - O(n)
        //Space -O(n)
        public int EvalRPN(string[] tokens)
        {
            int n = tokens.Length;
            HashSet<string> symbols = new HashSet<string>();
            symbols.Add("+");
            symbols.Add("-");
            symbols.Add("*");
            symbols.Add("/");

            Stack<string> myStack = new Stack<string>();
            int total = 0;
            foreach (var item in tokens)
            {
                if (symbols.Contains(item))
                {
                    int val1 = int.Parse(myStack.Pop());
                    int val2 = int.Parse(myStack.Pop());
                    switch (item)
                    {
                        case "*":
                            total = val2 * val1;
                            break;
                        case "/":
                            total = val2 / val1;
                            break;
                        case "+":
                            total = val2 + val1;
                            break;
                        case "-":
                            total = val2 - val1;
                            break;

                    }
                    myStack.Push(total.ToString());

                }
                else
                {
                    myStack.Push(item);
                }


            }
            return int.Parse(myStack.Pop());
        }

    }
}