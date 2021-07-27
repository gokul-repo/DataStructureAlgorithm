namespace DataStructureAlgorithm.Leetcode
{
    //430. Flatten a Multilevel Doubly Linked List
    //https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/
    public class FlattenMultilevelDLL
    {
        public Node1 Flatten(Node1 head)
        {
            if (head == null)
            {
                return null;
            }
            Node1 psuedoNode = new Node1(0, null, head, null);
            flattenDFS(psuedoNode, head);
            psuedoNode.next.prev = null;
            return psuedoNode.next;
        }

        public Node1 flattenDFS(Node1 prev, Node1 curr)
        {
            if (curr == null)
            {
                return prev;
            }
            curr.prev = prev;
            prev.next = curr;
            Node1 tempNode = curr.next;
            Node1 tail = flattenDFS(curr, curr.child);
            curr.child = null;
            return flattenDFS(tail, tempNode);
        }

        public Node1 FlattenStack(Node1 head)
        {
            if (head == null)
            {
                return null;
            }
            Node1 psuedoNode = new Node1(0, null, head, null);
            Node1 curr = psuedoNode;
            Node1 prev = psuedoNode;
            System.Collections.Stack myStack = new System.Collections.Stack();
            myStack.Push(head);
            while (myStack.Count != 0)
            {
                curr = (Node1)myStack.Pop();
                curr.prev = prev;
                prev.next = curr;
                if (curr.next != null)
                {
                    myStack.Push(curr.next);
                }
                if (curr.child != null)
                {
                    myStack.Push(curr.child);
                    curr.child = null;
                }
                prev = curr;
            }
            psuedoNode.next.prev = null;
            return psuedoNode.next;
        }
    }

    public class Node1
    {
        public int val;
        public Node1 prev;
        public Node1 next;
        public Node1 child;

        public Node1() { }

        public Node1(int _val, Node1 _prev, Node1 _next, Node1 _child)
        {
            val = _val;
            prev = _prev;
            next = _next;
            child = _child;
        }
    };
}