using System;

namespace DataStructureAlgorithm.Leetcode
{
    //104. Maximum Depth of Binary Tree
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/
    public class MaximumDepthofBinaryTree
    {

        //Time COmplexity - O(n)
        //Space COmplexity - Worst case whem tree is fully unbalanced = o(n) / WHen tree is perfect balanced - O(log n)
        //Bottom Up Approach
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }

        //TopDown
        public int answer;
        public int MaxDepthTopDown(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            helper(root, 1);
            return answer;
        }
        public void helper(TreeNode root, int depth)
        {
            if (root == null)
            {
                return;
            }
            if (root.left == null && root.right == null)
            {
                answer = Math.Max(answer, depth);
            }
            helper(root.left, depth + 1);
            helper(root.right, depth + 1);
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