using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //101. Symmetric Tree
    //https://leetcode.com/problems/symmetric-tree/
    public class SymmetricTree
    {
        //Recursive
        //Time - O(n)
        //Space - O(n)
        public bool IsSymmetric(TreeNode root)
        {
            return isMirror(root, root);
        }
        public bool isMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }
            if (t1 == null || t2 == null)
            {
                return false;
            }
            return (t1.val == t2.val) && isMirror(t1.right, t2.left) && isMirror(t1.left, t2.right);

        }
        //Iterative
        public bool IsSymmetricIterative(TreeNode root) {
            Queue<TreeNode> myQueue = new Queue<TreeNode>();
            myQueue.Enqueue(root);
            myQueue.Enqueue(root);
            while(myQueue.Count!=0){
                var t1 = myQueue.Dequeue();
                var t2 = myQueue.Dequeue();
                if(t1 ==null && t2==null){
                    continue;
                }
                if(t1==null || t2==null){
                    return false;
                }
                if(t1.val!=t2.val){
                    return false;
                }
                myQueue.Enqueue(t1.left);
                myQueue.Enqueue(t2.right);
                myQueue.Enqueue(t2.left);
                myQueue.Enqueue(t1.right);
            }
            return true;
        }
    }
}