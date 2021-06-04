using System;

namespace DataStructureAlgorithm.BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree(){
            Root=null;
        }

        //Search Recursive
        public bool SearchRecursive (Node root, int target){
            if (root == null){
                return false;
            }else if(target<root.Value){
                return SearchRecursive(root.LeftChild,target);
            }
            else if (target > root.Value){
                return SearchRecursive(root.RightChild,target);
            }else{
                return true;
            }

        }

         //Search Iterative
        public bool SearchIterative (Node root, int target){
            if (root == null){
                return false;
            }
            Node curr = root;

            while(curr!= null){
                if(curr.Value==target){
                    return true;
                }else if ( target <curr.Value){
                    curr=curr.LeftChild;
                }else{
                    curr=curr.RightChild;
                }
            }
            return false;
        }

         //Insert Recursive
        public Node InsertRecursive (Node root, int val){            
            if (root == null){                
                Node newNode = new Node(val);                
                return newNode;
            }else if(val<root.Value){
                 root.LeftChild=InsertRecursive(root.LeftChild,val);
            }
            else if (val > root.Value){
                root.RightChild =InsertRecursive(root.RightChild,val);
            }
            return root;

        }

        //Insert Iterative
        public void InsertIterative (Node root, int val){
            Node newNode = new Node(val);
            if (root == null){
                Root=newNode;
                return;
            }
            Node prev =null;
            Node curr = root;

            while(curr!= null){
                if(curr.Value==val){
                    Console.WriteLine("Duplicate");
                    return;
                }else if (val <curr.Value){
                    prev=curr;
                    curr=curr.LeftChild;
                }else{
                    prev=curr;
                    curr=curr.RightChild;
                }
            }
            if (val < prev.Value){
                prev.LeftChild=newNode;
            }else{
                prev.RightChild=newNode;
            }            
        }

        //InOrder Traversal
         public void inOrder(Node root){
            if(root==null){
                return;
            }
            inOrder(root.LeftChild);
            Console.WriteLine(root.Value);
            inOrder(root.RightChild);
        }

       //InOrder Successor
       public Node InOrderSuccessor(Node root){
           if (root == null ){
               return null;
           }
           Node prev=null;
           Node curr=root.RightChild;
           while (curr!=null)
           {
               prev=curr;
               curr=curr.LeftChild;               
           }
           return prev;
       }

       //InOrder Predeccesor
       public Node InOrderPredecessor(Node root){
           if (root == null ){
               return null;
           }
           Node prev=null;
           Node curr=root.LeftChild;
           while (curr!=null)
           {
               prev=curr;
               curr=curr.RightChild;               
           }
           return prev;
       }
                        
    }
}