using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //236. Lowest Common Ancestor of a Binary Tree
    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
    public class LowestCommonAncestorBinaryTree
    {
        //Recursion SOlution 1 (LC Official solution)
        public TreeNode ans;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }
            lca(root, p, q);
            return ans;
        }

        public bool lca(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return false;
            }

            int left = lca(root.left, p, q) ? 1 : 0;
            int right = lca(root.right, p, q) ? 1 : 0;
            int mid = (root == p || root == q) ? 1 : 0;
            if (left + right + mid == 2)
            {
                ans = root;
            }
            return left + right + mid > 0;
        }

        //Recursion Solution form Comments
        //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/discuss/317020/C-Readable-Recursion-Solution
        public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
            {
                return root;
            }
            var left = LowestCommonAncestor1(root.left, p, q);
            var right = LowestCommonAncestor1(root.right, p, q);
            if ((left == p && right == q) || (right == p && left == q))
            {
                return root;
            }
            return left ?? right;
        }
        //Recursion Solution form Comments
        public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
            {
                return root;
            }
            var left = LowestCommonAncestor2(root.left, p, q);
            var right = LowestCommonAncestor2(root.right, p, q);
            //Small change here from prev version
            if (left != null && right != null)
            {
                return root;
            }
            return left ?? right;
        }

        //Iterative
        public TreeNode LowestCommonAncestorIterative(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            Dictionary<TreeNode, TreeNode> myDict = new Dictionary<TreeNode, TreeNode>();
            myStack.Push(root);
            myDict.Add(root, null);
            while (!myDict.ContainsKey(p) || !myDict.ContainsKey(q))
            {
                var curr = myStack.Pop();
                if (curr.left != null)
                {
                    myDict.Add(curr.left, curr);
                    myStack.Push(curr.left);
                }
                if (curr.right != null)
                {
                    myDict.Add(curr.right, curr);
                    myStack.Push(curr.right);
                }
            }
            HashSet<TreeNode> ancestors = new HashSet<TreeNode>();
            while (p != null)
            {
                ancestors.Add(p);
                p = myDict[p];
            }
            while (!ancestors.Contains(q))
            {
                q = myDict[q];
            }
            return q;

        }

    }
}