using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //841. Keys and Rooms
    //https://leetcode.com/problems/keys-and-rooms/        
    public class KeysandRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int n = rooms.Count;
            bool[] seen = new bool[n];
            Stack<int> myStack = new Stack<int>();
            seen[0] = true;
            myStack.Push(0);
            while (myStack.Count != 0)
            {
                int curr = myStack.Pop();
                foreach (var key in rooms[curr])
                {
                    if (!seen[key])
                    {
                        myStack.Push(key);
                        seen[key] = true;
                    }
                }
            }
            foreach (var i in seen)
            {
                if (!i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}