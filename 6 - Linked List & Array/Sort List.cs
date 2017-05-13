using System;
using System.Collections;
using System.Collections.Generic;

namespace sortList
{

    ///Definition for ListNode
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
        public ListNode sortList(ListNode head) {
            if (head == null || head.next == null) {
                return head;
            }
            ListNode mid = findMid(head);
            ListNode right = sortList(mid.next);
            mid.next = null;
            ListNode left = sortList(head);
            return merge(left, right);
        }
        private ListNode findMid(ListNode head) {
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        private ListNode merge(ListNode head1, ListNode head2) {
            ListNode dummy = new ListNode(0);
            ListNode tail = dummy;
            while (head1 != null && head2 != null) {
                if (head1.val < head2.val) {
                    tail.next = head1;
                    head1 = head1.next;
                } else {
                    tail.next = head2;
                    head2 = head2.next;
                }
                tail = tail.next;
            }
            if (head1 != null) {
                tail.next = head1;
            }
            if (head2 != null) {
                tail.next = head2;
            }
            return dummy.next;
        }
    }
}