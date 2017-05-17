using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    public class Solution
    {
        public int TwoSum (int[] nums, int target) {
            if (nums == null || nums.Length < 2) {
                return 0;
            }
            int left = 0, right = nums.Length - 1;
            int ct = 0;
            while (left < right) {
                int v = nums[left] + nums[right];
                if (v > target) {
                    right--;
                } else {
                    ct += right - left;
                    left++;
                }
            }
            return ct;
        }
    }
}
