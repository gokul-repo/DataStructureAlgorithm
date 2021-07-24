namespace DataStructureAlgorithm.Leetcode
{
    //707. Design Linked List
    //https://leetcode.com/problems/design-linked-list/
    public class DesignLinkedList
    {

    }
    public class Node
    {
        public int val;
        public Node next;
        public Node(int x)
        {
            val = x;
        }
    }

    public class MyLinkedList
    {
        public int size;
        public Node Head;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            size = 0;
            Head = null;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index + 1 > size)
            {
                return -1;
            }
            var curr = Head;
            for (int i = 0; i < index; i++)
            {
                curr = curr.next;
            }
            return curr.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(size, val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > size)
            {
                return;
            }
            size++;
            Node newNode = new Node(val);
            if (index <= 0)
            {
                newNode.next = Head;
                Head = newNode;
                return;
            }
            Node prev = null;
            var curr = Head;
            for (int i = 0; i < index; i++)
            {
                prev = curr;
                curr = curr.next;
            }
            newNode.next = curr;
            prev.next = newNode;
            return;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= size)
            {
                return;
            }
            size--;
            if (index == 0)
            {
                Head = Head.next;
                return;
            }
            Node prev = null;
            var curr = Head;
            for (int i = 0; i < index; i++)
            {
                prev = curr;
                curr = curr.next;
            }
            prev.next = curr.next;
            return;
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}