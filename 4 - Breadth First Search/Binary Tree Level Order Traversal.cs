using System;
using System.Collections.Generic;

namespace LevelOrder
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
        * @return: Level order a list of lists of integer
        */
        public List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            if (root == null)
            {
                return result;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int size = queue.Count;
                List<int> level = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Add(level);
            }
            return result;
        }
    }
}