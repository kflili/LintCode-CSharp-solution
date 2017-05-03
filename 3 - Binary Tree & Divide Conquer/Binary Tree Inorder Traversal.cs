using System;
using System.Collections.Generic;

namespace InorderTraversal
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
    
    // Non-recursion
    public class Solution {
        public List<int> InorderTraversal(TreeNode root) {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> result = new List<int>();
            TreeNode curt = root;
            while (curt != null || stack.Count != 0) {
                while (curt != null) {
                    stack.Push(curt);
                    curt = curt.left;
                }
                curt = stack.Pop();
                result.Add(curt.val);
                curt = curt.right;
            }
            return result;
        }
    }
    // recursion
    public class Solution2 {
        public List<int> InorderTraversal (TreeNode root) {
            List<int> result = new List<int>();
            if (root == null) {
                return result;
            }
            result.AddRange(InorderTraversal(root.left));
            result.Add(root.val);
            result.AddRange(InorderTraversal(root.right));
            return result;
        }
    }
}