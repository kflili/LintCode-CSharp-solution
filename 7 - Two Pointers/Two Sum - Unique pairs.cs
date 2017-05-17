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
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1;
            int ct = 0;
            while (left < right) {
                int v = nums[left] + nums[right];
                if (v == target) {
                    ct++;
                    //move pointer
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right + 1]) {
                        right--;
                    }
                } else if (v < target) {
                    left++;
                } else {
                    right--;
                }
            }
            return ct;
        }
    }
}
