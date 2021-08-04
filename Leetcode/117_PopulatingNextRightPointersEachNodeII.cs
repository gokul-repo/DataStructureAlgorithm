using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //117. Populating Next Right Pointers in Each Node II
    //https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
    public class PopulatingNextRightPointersEachNodeII
    {
        //Same as 116 - using extra space (Queue)
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Queue<Node> myQueue = new Queue<Node>();
            myQueue.Enqueue(root);
            while (myQueue.Count != 0)
            {
                int size = myQueue.Count;
                for (int i = 0; i < size; i++)
                {
                    var curr = myQueue.Dequeue();
                    if (i < size - 1)
                    {
                        curr.next = myQueue.Peek();
                    }
                    if (curr.left != null)
                    {
                        myQueue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        myQueue.Enqueue(curr.right);
                    }
                }
            }
            return root;
        }

    }
}