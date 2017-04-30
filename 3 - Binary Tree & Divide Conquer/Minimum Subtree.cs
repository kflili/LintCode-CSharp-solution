using System;

namespace findSubtree
{

    // Definition of TreeNode:
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;
        public TreeNode(int val)
        {
            this.val = val;
            this.left = this.right = null;
        }
    }

    public class Solution
    {
        /**
         * @param root the root of binary tree
         * @return the root of the minimum subtree
         */
        class ResultType {
            public TreeNode minSubtree;
            public int sum, minSum;
            public ResultType (TreeNode minSubtree, int sum, int minSum) {
                this.minSubtree = minSubtree;
                this.sum = sum;
                this.minSum = minSum;
            }
        }

        public TreeNode findSubtree(TreeNode root)
        {
            ResultType result = helper(root);
            return result.minSubtree;
        }

        private ResultType helper(TreeNode root)
        {
            if (root == null)
            {
                return new ResultType(null, 0, int.MaxValue);
            }
            ResultType leftResult = helper(root.left);
            ResultType rightResult = helper(root.right);
            ResultType result = new ResultType(
                root,
                leftResult.sum + rightResult.sum + root.val,
                leftResult.sum + rightResult.sum + root.val
            );
            if (leftResult.minSum < result.minSum) {
                result.minSum = leftResult.minSum;
                result.minSubtree = leftResult.minSubtree;
            } 
            if (rightResult.minSum < result.minSum) {
                result.minSum = rightResult.minSum;
                result.minSubtree = rightResult.minSubtree;
            } 
            return result;
        }
    }
}