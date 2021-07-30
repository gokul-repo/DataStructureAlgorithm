using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //739. Daily Temperatures
    //https://leetcode.com/problems/daily-temperatures/
    public class DailyTemperatures
    {
        //Brute force
        //Time complexity - O(n^2)
        public int[] DailyTemperaturesBruteForce(int[] temperatures)
        {
            int length = temperatures.Length;
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < length; j++)
                {
                    count++;
                    if (temperatures[j] > temperatures[i])
                    {
                        result[i] = count;
                        break;
                    }
                }
            }
            return result;
        }

        //Stack - From end
        //Time - O(n)
        //Space - O(n)

        public int[] DailyTemperaturesStack(int[] temperatures)
        {
            int length = temperatures.Length;
            int[] result = new int[length];
            Stack<int[]> myStack = new Stack<int[]>();
            for (int i = length - 1; i >= 0; i--)
            {
                int curr = temperatures[i];
                while (myStack.Count != 0 && myStack.Peek()[0] <= curr)
                {
                    myStack.Pop();
                }
                result[i] = myStack.Count == 0 ? 0 : myStack.Peek()[1] - i;
                myStack.Push(new int[] { curr, i });

            }
            return result;

        }

        //Stack from Start
        //Time -O(n)
        //Space - O(n)
        public int[] DailyTemperaturesStack1(int[] temperatures)
        {
            int length = temperatures.Length;
            int[] result = new int[length];
            Stack<int> prevDayIdx = new Stack<int>();
            for (int i = 0; i < length; i++)
            {
                int curr = temperatures[i];
                while (prevDayIdx.Count != 0 && curr > temperatures[prevDayIdx.Peek()])
                {
                    int prevDay = prevDayIdx.Pop();
                    result[prevDay] = i - prevDay;

                }
                prevDayIdx.Push(i);
            }
            return result;
        }
    }
}