using System;
using System.Collections;
using System.Collections.Generic;

namespace Insert
{

    //Definition for ListNode
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public ListNode Insert (ListNode node, int x) {
            if (node == null) {
                node = new ListNode(x);
                node.next = node;
                return node;
            }
            ListNode p = node;
            ListNode prev = null;
            do
            {
                prev = p;
                p = p.next;
                if (x <= p.val && x >= prev.val)
                {
                    break;
                }
                if ((p.val < prev.val) && (x > p.val || x < prev.val))
                {
                    break;
                }
            } while (p != node);
            ListNode newNode = new ListNode(x);
            newNode.next = p;
            prev.next = newNode;
            return newNode;
        }
    }
}