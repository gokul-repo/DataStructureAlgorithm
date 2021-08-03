using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //145. Binary Tree Postorder Traversal
    //https://leetcode.com/problems/binary-tree-postorder-traversal/
    public class BinaryTreePostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
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
            dfs(root.left, result);
            dfs(root.right, result);
            result.Add(root.val);
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