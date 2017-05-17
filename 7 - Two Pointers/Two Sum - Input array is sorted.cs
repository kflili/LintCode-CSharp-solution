using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return null;
            }
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int v = nums[left] + nums[right];
                if (v == target)
                {
                    int[] results = new int[2] { left + 1, right + 1 };
                    return results;
                }
                else if (v < target)
                {
                    left++;
                }
                else
                {
                    right++;
                }
            }
            return null;
        }
    }
}
