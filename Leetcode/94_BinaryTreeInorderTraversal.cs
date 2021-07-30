using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //94. Binary Tree Inorder Traversal
    //https://leetcode.com/problems/binary-tree-inorder-traversal/
    public class BinaryTreeInorderTraversal
    {
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
        //Time complexity - O(n)
        //coz the recurrence relation is T(n)=2⋅T(n/2)+1.
        //Space - The worst case space required is O(n), and in the average case it's O(logn) where n is number of nodes.
        public class SolutionRecursion
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
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
                result.Add(root.val);
                dfs(root.right, result);
            }
        }

        public IList<int> InorderTraversalIterative(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            var curr = root;
            while (curr != null || myStack.Count != 0)
            {
                while (curr != null)
                {
                    myStack.Push(curr);
                    curr = curr.left;
                }
                curr = myStack.Pop();
                result.Add(curr.val);
                curr = curr.right;
            }
            return result;

        }

    }
}