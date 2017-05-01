using System;

namespace LongestConsecutive
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
    // Divide Conquer
    public class Solution1
    {
        /**
         * @param root the root of binary tree
         * @return the length of the longest consecutive sequence path
         */
        private class ResultType {
            int maxInSubtree;
            int maxFromRoot;
            public ResultType (int maxInSubtree, int maxFromRoot) {
                this.maxInSubtree = maxInSubtree;
                this.maxFromRoot = maxFromRoot;
            }
        }
        public int LongestConsecutive (TreeNode root) {
            return helper(root).maxInSubtree;
        }
        private ResultType helper (TreeNode root) {
            if (root == null)
            {
                return new ResultType(0, 0);
            }
            ResultType left = helper(root.left);
            ResultType right = helper(root.right);

            // 1 is the root itself.
            ResultType result = new ResultType(0, 1);

            // Math.max is used to save one compare between left and right
            if (root.left != null && root.val + 1 == root.left.val) {
                result.maxFromRoot = Math.max(
                    maxFromRoot,
                    left.maxFromRoot + 1
                );
            }
            if (root.right != null && root.val + 1 == root.right.val) {
                result.maxFromRoot = Math.max(
                    result.maxFromRoot,
                    right.maxFromRoot + 1
                ) ;
            }
            result.maxInSubtree = Math.max(
                result.maxFromRoot,
                Math.max(left.maxInSubtree, right.maxInSubtree)
            );
            return result;
        }
    }
    
    // Traverse + Divide Conquer
    public class Solution2
    {
        /**
         * @param root the root of binary tree
         * @return the length of the longest consecutive sequence path
         */
        private int longest;
        public int LongestConsecutive (TreeNode root) {
            longest = 0;
            helper(root);
            return longest;
        }
        private int helper (TreeNode root) {
            if (root == null)
            {
                return 0;
            }
            int left = helper(root.left);
            int right = helper(root.right);

            int subtreeLongest = 1; // at least for current node
            if (root.left != null && root.val + 1 == root.left.val)
            {
                subtreeLongest = Math.Max(subtreeLongest, left + 1);
            }
            if (root.right != null && root.val + 1 == root.right.val) {
                subtreeLongest = Math.Max(subtreeLongest, right + 1);
            }
            if (subtreeLongest > longest) {
                longest = subtreeLongest;
            }
            return subtreeLongest;
        }
    }
}