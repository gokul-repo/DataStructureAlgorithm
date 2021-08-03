using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //102. Binary Tree Level Order Traversal
    //https://leetcode.com/problems/binary-tree-level-order-traversal/
    public class BinaryTreeLevelOrderTraversal
    {
        //recursive solution
        //Time - O(n)
        //Space - O(n)
        public List<IList<int>> results = new List<IList<int>>();
        public List<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return results;
            }
            helper(root, 0);
            return results;
        }

        public void helper(TreeNode root, int level)
        {
            if (results.Count == level)
            {
                results.Add(new List<int>());
            }
            results[level].Add(root.val);
            if (root.left != null)
            {
                helper(root.left, level + 1);
            }
            if (root.right != null)
            {
                helper(root.right, level + 1);
            }
        }

        public List<IList<int>> LevelOrderIterative(TreeNode root)
        {
            List<IList<int>> output = new List<IList<int>>();
            if (root == null)
            {
                return output;
            }
            Queue<TreeNode> myQueue = new Queue<TreeNode>();
            int level = 0;
            myQueue.Enqueue(root);
            while (myQueue.Count != 0)
            {
                output.Add(new List<int>());
                int l = myQueue.Count;
                for (int i = 0; i < l; i++)
                {
                    var curr = myQueue.Dequeue();
                    output[level].Add(curr.val);
                    if (curr.left != null)
                    {
                        myQueue.Enqueue(curr.left);
                    }
                    if (curr.right != null)
                    {
                        myQueue.Enqueue(curr.right);
                    }
                }
                level++;
            }
            return output;

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