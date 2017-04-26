using System;

namespace codeTest
{
    public class Solution
    {
        /**
        * @param nums: a rotated sorted array
        * @return: the minimum number in the array
        */
        public int FindMin (int[] nums) {
            if (nums == null || nums.Length == 0) {
                return -1;
            }
            int start = 0, end = nums.Length - 1;
            while (start + 1 < end) {
                int mid = start + (end - start) / 2;
                if (nums[mid] > nums[nums.Length - 1])
                {
                    start = mid;
                } else
                {
                    end = mid;
                }
            }
            return nums[start] < nums[end] ? nums[start] : nums[end];
        }
    }
}
