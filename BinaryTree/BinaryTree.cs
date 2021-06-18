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

         public void LevelOrder(Node root){
            if(root==null){
                return;
            }
            System.Collections.Queue queue = new System.Collections.Queue();
            Console.WriteLine(root.Value);
            queue.Enqueue(root);
            while (queue.Count!=0){
                Node curr = (Node)queue.Dequeue();
                if(curr.LeftChild!=null){
                    Console.WriteLine(curr.LeftChild.Value);
                    queue.Enqueue(curr.LeftChild);
                }
                if(curr.RightChild!=null){
                    Console.WriteLine(curr.RightChild.Value);
                    queue.Enqueue(curr.RightChild);
                }
            }            
        }

        public void PreOrderIterative(Node root){
            if (root == null){
                return;
            }
            System.Collections.Stack myStack = new System.Collections.Stack();
            var curr= root;           
            while ( curr != null || myStack.Count!=0){
                if (curr != null){
                    Console.WriteLine(curr.Value);
                    myStack.Push(curr);
                    curr=curr.LeftChild;
                }else{
                     curr = (Node)myStack.Pop();
                     curr=curr.RightChild;                   
                }
            }

        }

        public void InOrderIterative(Node root){
            if (root == null){
                return;
            }
            System.Collections.Stack myStack = new System.Collections.Stack();
            var curr= root;           
            while ( curr != null || myStack.Count!=0){
                if (curr != null){                    
                    myStack.Push(curr);
                    curr=curr.LeftChild;
                }else{
                     curr = (Node)myStack.Pop();
                     Console.WriteLine(curr.Value);
                     curr=curr.RightChild;                   
                }
            }

        }
        public void PostOrderIterative(Node root){

        }

        public int Count(Node root){
            if (root == null){
                return 0;
            }
            int x= Count(root.LeftChild);
            int y= Count(root.RightChild);
            return x+y+1;
        }

        public int CountLeaf(Node root){
            if(root == null){
                return 0;
            }
            int x= CountLeaf(root.LeftChild);
            int y= CountLeaf(root.RightChild);
            if (root.LeftChild==null&& root.RightChild==null){
                return x+y+1;
            }
            return x+y;
        }

        public int CountNonLeaf(Node root){
            if(root == null){
                return 0;
            }
            int x= CountNonLeaf(root.LeftChild);
            int y= CountNonLeaf(root.RightChild);
            if (root.LeftChild!=null || root.RightChild!=null){
                return x+y+1;
            }
            return x+y;
        }

         public int Height(Node root){
            if(root == null){
                return 0;
            }
            int x= Height(root.LeftChild);
            int y= Height(root.RightChild);
            if (x >y){
                return x+1;
            }else{
                return y+1;
            }         
        }

        public int SumOfLeafNodes(Node root){
            if(root == null){
                return 0;
            }
            if(root.LeftChild ==null && root.RightChild==null){
                return root.Value;
            }
            int total = 0;
            total += SumOfLeafNodes(root.LeftChild);
            total += SumOfLeafNodes(root.RightChild);
            return total;
        }
          
    }
}