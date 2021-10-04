namespace DataStructureAlgorithm.Leetcode
{
    //700. Search in a Binary Search Tree
    //https://leetcode.com/problems/search-in-a-binary-search-tree/
    public class SearchinaBinarySearchTree
    {
        //Recursion
        //Time - O(H) which is O(log n) in average case or O(n) in worst case
        //Space -O(H) stack space
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val)
            {
                return root;
            }
            if (val < root.val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
        }
        //Iterative
        // Time - O(H)
        // SPace - O(1)
        public TreeNode SearchBSTIterative(TreeNode root, int val)
        {
            while (root != null)
            {
                if (val < root.val)
                {
                    root = root.left;
                }
                else if (val > root.val)
                {
                    root = root.right;
                }
                else
                {
                    break;
                }
            }
            return root;
        }

    }
}