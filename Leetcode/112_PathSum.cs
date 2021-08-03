namespace DataStructureAlgorithm.Leetcode
{
    //112. Path Sum
    //https://leetcode.com/problems/path-sum/
    public class PathSum
    {
        //Recursion
        //Time - O(n)
        //Space -O(n) to O(log n)
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return dfs(root, targetSum, 0);
        }
        public bool dfs(TreeNode root, int targetSum, int sum)
        {
            if (root == null)
            {
                return false;
            }
            sum = sum + root.val;
            if (root.left == null && root.right == null)
            {
                return sum == targetSum;
            }
            return dfs(root.left, targetSum, sum) || dfs(root.right, targetSum, sum);


        }

    }
}