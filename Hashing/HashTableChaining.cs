
namespace DataStructureAlgorithm.Hashing
{

    //Chaining
    public class Node
    {
        public int Value;
        public Node Next;
        public Node Prev;

        public Node(int val)
        {
            Value = val;
        }
    }
    public class HashTable
    {
        public Node[] HTable;
        public int HSize;
        public HashTable(int Size)
        {
            HSize = Size;
            HTable = new Node[Size];
        }

        public int HashFunction(int value)
        {
            return value % HSize;
        }

        public void Insert(int value)
        {            
            int key = HashFunction(value);
            if (HTable[key] == null)
            {                
                //Insert at head
                Node newNode = new Node(value);
                HTable[key] = newNode;
                return;
            }
            //Insert in a sorted way
            var currNode = HTable[key];
            HTable[key] = InsertSort(currNode, value);

        }

        public bool Search(int value){
            int key = HashFunction(value);
            var currNode = HTable[key];
            while(currNode!=null){
                if(currNode.Value ==value){
                    return true;
                }
                currNode=currNode.Next;                
            }
            return false;
        }
        public Node InsertSort(Node head, int value)
        {
            Node newNode = new Node(value);
            //Insert at head
            if (value < head.Value)
            {
                newNode.Next = head;
                head.Prev = newNode;
                return newNode;
            }
            Node currNode = head.Next;
            Node prevNode = head;
            while (currNode != null && currNode.Value < value)
            {
                prevNode = currNode;
                currNode = currNode.Next;
            }
            prevNode.Next = newNode;
            newNode.Next = currNode;
            newNode.Prev = prevNode;
            if (currNode != null)
            {
                //This check is needed if inserting at tail
                currNode.Prev = newNode;
            }
            return head;
        }
    }
}