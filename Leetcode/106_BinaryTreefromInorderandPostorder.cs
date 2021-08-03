using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //106. Construct Binary Tree from Inorder and Postorder Traversal
    //https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/

    //Time - O(n) - Masters Theorem for dividing function - see LC explanation
    //Space - O(n) - we store all the nodes for generating the tree
    public class BinaryTreefromInorderandPostorder
    {
        public int[] inOrder;
        public int[] postOrder;
        public int postIdx;
        public Dictionary<int, int> inOrderMap = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            inOrder = inorder;
            postOrder = postorder;
            postIdx = postOrder.Length - 1;
            for (int i = 0; i < inorder.Length; i++)
            {
                inOrderMap.Add(inorder[i], i);
            }
            return helper(0, inOrder.Length - 1);
        }

        public TreeNode helper(int in_strt, int in_end)
        {
            if (in_strt > in_end)
            {
                return null;
            }
            int rootval = postOrder[postIdx];
            TreeNode root = new TreeNode(rootval);
            postIdx--;
            root.right = helper(inOrderMap[rootval] + 1, in_end);
            root.left = helper(in_strt, inOrderMap[rootval] - 1);
            return root;
        }

    }
}