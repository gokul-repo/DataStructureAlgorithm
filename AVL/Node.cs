namespace DataStructureAlgorithm.AVL
{
    public class Node
    {
        public int Value;
        public int Height;
        public Node LeftChild;
        public Node RightChild;
        public Node(int val){
            Value=val;
            Height=1;
        }

    }
}