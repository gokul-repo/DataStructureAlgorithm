using System;
using System.Collections;

namespace DataStructureAlgorithm.BinaryTree
{
    public class BinaryTrees
    {
        public Node RootNode;

        public BinaryTrees(){
            RootNode=null;
        }

        //Creating a Binary Tree using a Queue
        public Node Create(){            
            System.Collections.Queue queue = new  System.Collections.Queue();
            Console.WriteLine("Enter the Root Node :");
            int val = Convert.ToInt16(Console.ReadLine());
            Node rootNode = new Node(val);
            queue.Enqueue(rootNode);
            while(queue.Count != 0){
                 Node currNode = (Node)queue.Dequeue();
                 Console.WriteLine("Enter the Left Child :");
                 int lVal = Convert.ToInt16(Console.ReadLine());
                 if(lVal != -1){
                     Node leftChild= new Node(lVal);
                     currNode.LeftChild= leftChild;
                     queue.Enqueue(leftChild);
                 }
               
                 Console.WriteLine("Enter the Right Child :");
                 int rVal = Convert.ToInt16(Console.ReadLine());
                 if(rVal != -1){
                     Node rightChild= new Node(rVal);
                     currNode.RightChild= rightChild;
                     queue.Enqueue(rightChild);
                 }
            }
            RootNode=rootNode;
            return rootNode;
        }

        public void inOrder(Node root){
            if(root==null){
                return;
            }
            inOrder(root.LeftChild);
            Console.WriteLine(root.Value);
            inOrder(root.RightChild);
        }

         public void preOrder(Node root){
            if(root==null){
                return;
            }
             Console.WriteLine(root.Value);
            preOrder(root.LeftChild);           
            preOrder(root.RightChild);
        }

         public void postOrder(Node root){
            if(root==null){
                return;
            }
            
            postOrder(root.LeftChild);           
            postOrder(root.RightChild);
            Console.WriteLine(root.Value);
        }
    }
}