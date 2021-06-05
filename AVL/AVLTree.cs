using System;

namespace DataStructureAlgorithm.AVL
{
    public class AVLTree
    {
        public Node Root;
        public AVLTree()
        {
            Root = null;
        }

        public int NodeHeight(Node curr)
        {
            if (curr == null)
            {
                return 0;
            }
            int leftChildHeight = curr != null && curr.LeftChild != null ? curr.LeftChild.Height : 0;
            int rightChildHeight = curr != null && curr.RightChild != null ? curr.RightChild.Height : 0;

            return leftChildHeight > rightChildHeight ? leftChildHeight + 1 : rightChildHeight + 1;
        }

        public int BalanceFactor(Node curr)
        {
            if (curr == null)
            {
                return 0;
            }
            int leftChildHeight = curr != null && curr.LeftChild != null ? curr.LeftChild.Height : 0;
            int rightChildHeight = curr != null && curr.RightChild != null ? curr.RightChild.Height : 0;

            return leftChildHeight - rightChildHeight;
        }

        public Node LLRotation(Node root)
        {
            Node newRoot = root.LeftChild;
            Node newRootRight = newRoot.RightChild;
            newRoot.RightChild = root;
            root.LeftChild = newRootRight;
            root.Height = NodeHeight(root);
            newRoot.Height = NodeHeight(newRoot);

            if (root == Root)
            {
                Root = newRoot;
            }
            return newRoot;
        }

        public Node RRRotation(Node root)
        {
            Node newRoot = root.RightChild;
            Node newRootLeft = newRoot.LeftChild;
            newRoot.LeftChild = root;
            root.RightChild = newRootLeft;
            root.Height = NodeHeight(root);
            newRoot.Height = NodeHeight(newRoot);
            if (root == Root)
            {
                Root = newRoot;
            }
            return newRoot;
        }

        public Node LRRotation(Node root)
        {
            Node rootLeft = root.LeftChild;
            Node rootLeftRight = rootLeft.RightChild;

            rootLeft.RightChild = rootLeftRight.LeftChild;
            root.LeftChild = rootLeftRight.RightChild;
            rootLeftRight.LeftChild = rootLeft;
            rootLeftRight.RightChild = root;

            rootLeft.Height = NodeHeight(rootLeft);
            root.Height = NodeHeight(root);
            rootLeftRight.Height = NodeHeight(rootLeftRight);

            if (Root == root)
            {
                Root = rootLeftRight;
            }
            return rootLeftRight;
        }

        public Node RLRotation(Node root)
        {
            Node rootRight = root.RightChild;
             Node rootRightLeft = rootRight.LeftChild;

            rootRight.LeftChild = rootRightLeft.RightChild;
            root.RightChild = rootRightLeft.LeftChild;
            rootRightLeft.RightChild = rootRight;
            rootRight.LeftChild = root;

            rootRight.Height = NodeHeight(rootRight);
            root.Height = NodeHeight(root);
            rootRightLeft.Height = NodeHeight(rootRightLeft);


            if (Root == root)
            {
                Root = rootRightLeft;
            }
            return rootRightLeft;
        }

        public Node Insert(Node root, int val)
        {
            Node newNode = new Node(val);
            if (root == null)
            {                
                return newNode;
            }

            if (val < root.Value)
            {
                root.LeftChild = Insert(root.LeftChild, val);
            }
            else if (val > root.Value)
            {
                root.RightChild = Insert(root.RightChild, val);
            }
            root.Height = NodeHeight(root);



            if (BalanceFactor(root) == 2 && BalanceFactor(root.LeftChild) == 1)
            {
                //LL ImBalance - Right rotation (or) LL Rotation (or) Clockwise
                return LLRotation(root);

            }
            else if (BalanceFactor(root) == 2 && BalanceFactor(root.LeftChild) == -1)
            {
                //LR Rotation
                return LRRotation(root);

            }
            else if (BalanceFactor(root) == -2 && BalanceFactor(root.RightChild) == -1)
            {
                //RR ImBalance - Left rotation (or) RR Rotation (or) Counter Clockwise
                return RRRotation(root);
            }
            else if (BalanceFactor(root) == -2 && BalanceFactor(root.RightChild) == 1)
            {
                //RL Rotation
                return RLRotation(root);
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