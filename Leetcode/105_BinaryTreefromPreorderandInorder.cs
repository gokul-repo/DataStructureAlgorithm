using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //105. Construct Binary Tree from Preorder and Inorder Traversal
    //https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

    //Complexity same as 106
    public class BinaryTreefromPreorderandInorder
    {
        public int[] preOrder;
        public int[] inOrder;
        public int preIdx;
        public Dictionary<int, int> indexMap = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            preOrder = preorder;
            inOrder = inorder;
            preIdx = 0;
            for (int i = 0; i < inOrder.Length; i++)
            {
                indexMap.Add(inOrder[i], i);
            }
            return helper(0, inOrder.Length - 1);
        }
        public TreeNode helper(int in_strt, int in_end)
        {
            if (in_strt > in_end)
            {
                return null;
            }
            int rootval = preOrder[preIdx];
            TreeNode root = new TreeNode(rootval);
            preIdx++;
            root.left = helper(in_strt, indexMap[rootval] - 1);
            root.right = helper(indexMap[rootval] + 1, in_end);
            return root;
        }
    }
}