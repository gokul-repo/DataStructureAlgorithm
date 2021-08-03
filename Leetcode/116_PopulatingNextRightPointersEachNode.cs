using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //116. Populating Next Right Pointers in Each Node
    //https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    public class PopulatingNextRightPointersEachNode
    {

        //Level order with Queue
        //Time - O(n)
        //Space - O(n) - Since we use Queue and for a perfect binary tree the leask level will exactly have n/2 nodes
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
                    Node curr = myQueue.Dequeue();
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

        //Wihout using xtra space (Queue)
        //Time - O(n)
        //Space - O(1)

        public Node ConnectNoQueue(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Node leftMost = root;
            while (leftMost.left != null)
            {
                var head = leftMost;
                while (head != null)
                {
                    head.left.next = head.right;
                    if (head.next != null)
                    {
                        head.right.next = head.next.left;
                    }
                    head = head.next;
                }
                leftMost = leftMost.left;
            }
            return root;

        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}