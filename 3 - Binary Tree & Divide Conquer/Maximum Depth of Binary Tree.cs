using System;
using System.Collections.Generic;

namespace MaxDepth
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
        * @return: An integer.
        */
        public int MaxDepth(TreeNode root) {
            if (root == null) {
                return 0;
            }
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }       
    }
}