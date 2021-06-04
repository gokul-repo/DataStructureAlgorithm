using System;

namespace DataStructureAlgorithm.BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        //Search Recursive
        public bool SearchRecursive(Node root, int target)
        {
            if (root == null)
            {
                return false;
            }
            else if (target < root.Value)
            {
                return SearchRecursive(root.LeftChild, target);
            }
            else if (target > root.Value)
            {
                return SearchRecursive(root.RightChild, target);
            }
            else
            {
                return true;
            }

        }

        //Search Iterative
        public bool SearchIterative(Node root, int target)
        {
            if (root == null)
            {
                return false;
            }
            Node curr = root;

            while (curr != null)
            {
                if (curr.Value == target)
                {
                    return true;
                }
                else if (target < curr.Value)
                {
                    curr = curr.LeftChild;
                }
                else
                {
                    curr = curr.RightChild;
                }
            }
            return false;
        }

        //Insert Recursive
        public Node InsertRecursive(Node root, int val)
        {
            if (root == null)
            {
                Node newNode = new Node(val);
                return newNode;
            }
            else if (val < root.Value)
            {
                root.LeftChild = InsertRecursive(root.LeftChild, val);
            }
            else if (val > root.Value)
            {
                root.RightChild = InsertRecursive(root.RightChild, val);
            }
            return root;

        }

        //Insert Iterative
        public void InsertIterative(Node root, int val)
        {
            Node newNode = new Node(val);
            if (root == null)
            {
                Root = newNode;
                return;
            }
            Node prev = null;
            Node curr = root;

            while (curr != null)
            {
                if (curr.Value == val)
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
                else if (val < curr.Value)
                {
                    prev = curr;
                    curr = curr.LeftChild;
                }
                else
                {
                    prev = curr;
                    curr = curr.RightChild;
                }
            }
            if (val < prev.Value)
            {
                prev.LeftChild = newNode;
            }
            else
            {
                prev.RightChild = newNode;
            }
        }

        //InOrder Traversal
        public void inOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            inOrder(root.LeftChild);
            Console.WriteLine(root.Value);
            inOrder(root.RightChild);
        }

        //InOrder Successor
        public Node InOrderSuccessor(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Node prev = null;
            Node curr = root.RightChild;
            while (curr != null)
            {
                prev = curr;
                curr = curr.LeftChild;
            }
            return prev;
        }

        //InOrder Predeccesor
        public Node InOrderPredecessor(Node root)
        {
            if (root == null)
            {
                return null;
            }
            Node prev = null;
            Node curr = root.LeftChild;
            while (curr != null)
            {
                prev = curr;
                curr = curr.RightChild;
            }
            return prev;
        }

        //Height
        public int Height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int x = Height(root.LeftChild);
            int y = Height(root.RightChild);
            if (x > y)
            {
                return x + 1;
            }
            else
            {
                return y + 1;
            }
        }

        //Delete

        public Node Delete(Node root, int val){
            if (root == null){
                return null;
            }
            if(root.LeftChild == null && root.RightChild ==null){
                    root = null;
                    return root;
            }
            
            if(val<root.Value){
                root.LeftChild=Delete(root.LeftChild,val);
            }else if(val>root.Value){
                root.RightChild=Delete(root.RightChild,val);
            }else{
                if (Height(root.LeftChild) > Height(root.RightChild)){
                    Node pred = InOrderPredecessor(root);
                    root.Value=pred.Value;
                    root.LeftChild =Delete(root.LeftChild,pred.Value);
                }else{
                    Node Succ = InOrderSuccessor(root);
                    root.Value=Succ.Value;
                    root.RightChild=Delete(root.RightChild,Succ.Value);
                }
            }
            return root;
        }

    }
}