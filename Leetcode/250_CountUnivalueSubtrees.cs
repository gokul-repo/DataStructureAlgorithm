using System;

namespace DataStructureAlgorithm.Leetcode
{
    //250. Count Univalue Subtrees
    //https://leetcode.com/problems/count-univalue-subtrees/
    public class CountUnivalueSubtrees
    {
        // Time - O(n)
        //Space - O(h) the left sub tree is first evaluated befor the right sub tree so the stack will grow max to the height of the tree
        int count = 0;
        public int CountUnivalSubtrees(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            eval(root);
            return count;
        }
        public bool eval(TreeNode root)
        {
            if (root.left == null  && root.right == null)
            {
                count++;
                return true;
            }
            bool isUniVal = true;
            if (root.left != null)
            {
                isUniVal = eval(root.left) && isUniVal && root.val == root.left.val;
            }
            if (root.right != null)
            {
                isUniVal = eval(root.right) && isUniVal && root.val == root.right.val;
            }
            if (isUniVal)
            {
                count++;
                return true;
            }
            return false;
        }        

        public int CountUnivalSubtrees1(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Console.WriteLine(eval(root, 0));
            return count;
        }
        public bool eval(TreeNode root, int val)
        {
            if (root == null)
            {
                return true;
            }
            if (!eval(root.left, root.val) | !eval(root.right, root.val))
            {
                return false;
            }
            count++;
            return val == root.val;
        }

    }
}