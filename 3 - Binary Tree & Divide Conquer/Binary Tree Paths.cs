using System;
using System.Collections.Generic;

namespace BinaryTreePaths
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
    
    public class Solution {
    /**
    * @param root the root of the binary tree
    * @return all root-to-leaf paths
    */
        public List<string> BinaryTreePaths (TreeNode root) {
            List<string> paths = new List<string>();
            if (root == null) {
                return paths;
            }
            List<string> leftPaths = BinaryTreePaths(root.left);
            List<string> rightPaths = BinaryTreePaths(root.right);
            foreach (var path in leftPaths)
            {
                paths.Add(root.val + "->" + path);
            }
            foreach (var path in rightPaths)
            {
                paths.Add(root.val + "->" + path);
            }
            // root is a leaf
            if (root.left == null && root.right == null) {
                paths.Add("" + root.val);
            }
            return paths;
        }
    }
}