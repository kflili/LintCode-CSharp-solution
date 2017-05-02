using System;
using System.Collections.Generic;

namespace IsBalanced
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
        * @param root: The root of binary tree.
        * @return: True if this Binary tree is Balanced, or false.
        */
        public bool IsBalanced (TreeNode root) {
            return MaxDepth(root) != -1;
        }

        public int MaxDepth (TreeNode root) {
            if (root == null) {
                return 0;
            }

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            if (left == -1 || right == -1 || Math.Abs(left - right) > 1) {
                return -1;
            }
            return Math.Max(left, right) + 1;
        }
    }
}