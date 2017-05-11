using System;
using System.Collections;
using System.Collections.Generic;

namespace MaxSubArray
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
        public int MaxSubArray (int[] nums) {
            if (nums == null || nums.Length == 0) {
                return 0;
            }
            int max = int.MinValue;
            int sum = 0, minSum = 0;
            for (int i = 0; i < nums.Length; i++) {
                sum += nums[i];
                max = Math.Max(max, sum - minSum);
                minSum = Math.Min(minSum, sum);
            }
            return max;
        }
    }
}