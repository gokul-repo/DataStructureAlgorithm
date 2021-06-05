using System;

namespace DataStructureAlgorithm.AVL
{
    //Insert into AVL in a different way as per GeekFOrGeeks
    public class AVL2
    {
        public Node Root;

        public AVL2(){
            Root = null;
        }

        public int NodeHeight(Node root){

            int leftSubTreeHeight = root.LeftChild != null ? root.LeftChild.Height : 0;
            int rightSubTreeHeight = root.RightChild != null ? root.RightChild.Height : 0;

            return leftSubTreeHeight >rightSubTreeHeight ? leftSubTreeHeight +1 : rightSubTreeHeight+1;

        }

        public int BalanceFactor(Node root){
            int leftSubTreeHeight = root.LeftChild != null ? root.LeftChild.Height : 0;
            int rightSubTreeHeight = root.RightChild != null ? root.RightChild.Height : 0;

            return leftSubTreeHeight - rightSubTreeHeight;
        }

        //NOTE : This is also called as RR rotate as per AB
        public Node LeftRotate(Node z){
            
            Node y= z.RightChild;
            Node T2 = y.LeftChild;

            //Rotate
            y.LeftChild=z;
            z.RightChild = T2;
             
             z.Height=NodeHeight(z);
             y.Height=NodeHeight(y);

             if(z == Root){
                 Root =y;
             }

             return y;
        }

        //NOTE : This is also called as LL rotate as per AB
         public Node RightRotate(Node z){
             Node y= z.LeftChild;
             Node T3 = y.RightChild;

             //Rotate
             y.RightChild=z;
             z.LeftChild= T3;

             z.Height=NodeHeight(z);
             y.Height=NodeHeight(y);
            if(z == Root){
                 Root =y;
             }
             return y;
            
        }

        public Node Insert(Node root,int val){

            Node newNode = new Node(val);
            if (root==null){
                return newNode;
            }
            if(val < root.Value){
                root.LeftChild = Insert(root.LeftChild,val);
            }else if( val > root.Value){
                root.RightChild= Insert(root.RightChild,val);
            }

            root.Height= NodeHeight(root);

            if( BalanceFactor(root) >1 &&  val < root.LeftChild.Value ){                
                //LL scenario
                return RightRotate(root);
            }else if( BalanceFactor(root) >1 &&  val > root.LeftChild.Value ){
                //LR Scenario
                root.LeftChild =LeftRotate(root.LeftChild);
                return RightRotate(root);
            }else if( BalanceFactor(root) <-1 &&  val > root.RightChild.Value ){
                //RR Scenario
                return LeftRotate(root);
            }if( BalanceFactor(root) >1 &&  val < root.RightChild.Value ){
                //RL Scenario
                root.RightChild = RightRotate(root.RightChild);
                return LeftRotate(root);
            }

            return root;


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
    }
}