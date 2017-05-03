using System;
using System.Collections.Generic;

namespace PreorderTraversal
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
    public class Solution
    {
        public List<int> preorderTraversal(TreeNode root) {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> preorder = new List<int>();
            if (root == null) {
                return preorder;
            }

            stack.Push(root);
            while (stack.Count != 0) {
                TreeNode node = stack.Pop();
                preorder.Add(node.val);
                if (node.right != null) {
                    stack.Push(node.right);
                }
                if (node.left != null) {
                    stack.Push(node.left);
                }
            }
            return preorder;
        }
    }

    //Divide & Conquer
    public class Solution2 {
        public List<int> preorderTraversal(TreeNode root) {
            List<int> result = new List<int>();
            if (root == null) {
                return result;
            }
            //Divide
            List<int> left = preorderTraversal(root.left);
            List<int> right = preorderTraversal(root.right);

            //Conquer
            result.Add(root.val);
            result.AddRange(left);
            result.AddRange(right);

            return result;
        }
    }
}