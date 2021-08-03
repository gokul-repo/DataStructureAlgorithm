using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //144. Binary Tree Preorder Traversal
    //https://leetcode.com/problems/binary-tree-preorder-traversal/
    public class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversalRecursion(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            List<int> result = new List<int>();
            dfs(root, result);
            return result;
        }

        public void dfs(TreeNode root, List<int> result)
        {
            if (root == null)
            {
                return;
            }
            result.Add(root.val);
            dfs(root.left, result);
            dfs(root.right, result);
        }

        public IList<int> PreorderTraversalIterative(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            var curr = root;
            while (curr != null || myStack.Count != 0)
            {
                if (curr != null)
                {
                    myStack.Push(curr);
                    result.Add(curr.val);
                    curr = curr.left;
                }
                else
                {
                    curr = myStack.Pop();
                    curr = curr.right;
                }
            }
            return result;

        }
        //LC Solution easy to understand - firt push right then left
        public IList<int> PreorderTraversalLCSolution(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            myStack.Push(root);
            while (myStack.Count != 0)
            {
                var curr = myStack.Pop();
                result.Add(curr.val);
                if (curr.right != null)
                {
                    myStack.Push(curr.right);
                }
                if (curr.left != null)
                {
                    myStack.Push(curr.left);
                }
            }
            return result;
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}