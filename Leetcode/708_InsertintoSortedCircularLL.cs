namespace DataStructureAlgorithm.Leetcode
{
    //708. Insert into a Sorted Circular Linked List
    //https://leetcode.com/problems/insert-into-a-sorted-circular-linked-list/
    public class InsertintoSortedCircularLL
    {
        public Node Insert(Node head, int insertVal)
        {
            Node newNode = new Node(insertVal);
            if (head == null)
            {
                head = newNode;
                head.next = head;
                return head;
            }
            bool insert = false;
            Node curr = head.next;
            Node prev = head;
            do
            {
                if (prev.val <= insertVal && insertVal <= curr.val)
                {
                    insert = true;
                }
                else if (prev.val > curr.val)
                {
                    if (insertVal >= prev.val || insertVal <= curr.val)
                    {
                        insert = true;
                    }
                }
                if (insert)
                {
                    prev.next = newNode;
                    newNode.next = curr;
                    return head;
                }
                prev = curr;
                curr = curr.next;

            } while (prev != head);
            prev.next = newNode;
            newNode.next = curr;
            return head;
        }

    }
}