using System;
using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //270. Closest Binary Search Tree Value
    //https://leetcode.com/problems/closest-binary-search-tree-value/
    public class ClosestBinarySearchTreeValue
    {
        //Recursion - In Order
        //Time - O(n)
        //Space - O(n)
        public int ClosestValue(TreeNode root, double target)
        {
            List<int> nums = new List<int>();
            inorder(root, nums);
            nums.Sort((a, b) => Math.Abs(target - a).CompareTo(Math.Abs(target - b)));
            return nums[0];
        }

        public void inorder(TreeNode root, List<int> vals)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left, vals);
            vals.Add(root.val);
            inorder(root.right, vals);
        }

        //O(k) - see LC
        public int ClosestValue1(TreeNode root, double target)
        {
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            int pred = int.MinValue;
            while (myStack.Count != 0 || root != null)
            {
                while (root != null)
                {
                    myStack.Push(root);
                    root = root.left;
                }
                var curr = myStack.Pop();
                if (pred <= target && target < curr.val)
                {
                    int output = (Math.Abs(target - pred) < Math.Abs(target - curr.val)) ? pred : curr.val;
                    return output;
                }
                pred = curr.val;
                root = curr.right;
            }
            return pred;
        }
        // Binary Search
        //Time - O(h)
        //Space O(1)
        public int ClosestValueBinarySearch(TreeNode root, double target)
        {
            int closest = root.val;
            while (root != null)
            {
                int val = root.val;
                closest = Math.Abs(val - target) < Math.Abs(closest - target) ? val : closest;
                root = target < root.val ? root.left : root.right;
            }
            return closest;
        }

    }
}