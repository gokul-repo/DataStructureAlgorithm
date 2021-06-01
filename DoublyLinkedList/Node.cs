namespace DataStructureAlgorithm.DoublyLinkedList
{
    public class Node
    {
        public int Value;
        public Node Prev;
        public Node Next;
        public Node(int val)
        {
            Value = val;
            Next = null;
            Prev=null;
        }
    }
}