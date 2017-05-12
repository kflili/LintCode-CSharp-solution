using System;
using System.Collections;
using System.Collections.Generic;

namespace SubarraySumClosest
{

    //Definition for ListNode
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Pair
    {
        public int sum;
        public int index;
        public Pair(int s, int i)
        {
            sum = s;
            index = i;
        }
    }
    public class Solution
    {

        public int[] SubarraySumClosest(int[] nums)
        {
            int[] res = new int[2];
            if (nums == null || nums.Length == 0)
            {
                return res;
            }
            if (nums.Length == 1)
            {
                res[0] = res[1] = 0;
                return res;
            }
            Pair[] sums = new Pair[nums.Length + 1];
            int prev = 0;
            sums[0] = new Pair(0, 0);
            for (int i = 1; i <= nums.Length; i++)
            {
                sums[i] = new Pair(prev + nums[i - 1], i);
                prev = sums[i].sum;
            }
            Array.Sort(sums, (a, b) => (a.sum - b.sum));
            int ans = int.MaxValue;
            int[] temp = new int[2];
            for (int i = 1; i <= nums.Length; i++) {
                if (ans > sums[i].sum - sums[i - 1].sum) {
                    ans = sums[i].sum - sums[i - 1].sum;
                    temp = new int[]{ sums[i].index - 1, sums[i - 1].index - 1 };
                } 
            }
            Array.Sort(temp);
            res[0] = temp[0] + 1;
            res[1] = temp[1];
        }
    }
}