using System;
using System.Collections;
using System.Collections.Generic;

namespace SubarraySum
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
        public List<int> SubarraySum(int[] nums) {
            List<int> ans = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                sum += nums[i];
                if (dict.ContainsKey(sum)){
                    ans.Add(dict[sum] + 1);
                    ans.Add(i);
                    return ans;
                }
                dict.Add(sum, i);
            }
            return ans;
        }
    }
}