using System;

namespace LastPosition
{
    public class Solution
    {
    /**
     * @param nums: An integer array sorted in ascending order
     * @param target: An integer
     * @return an integer
     */
        public int LastPosition (int[] nums, int target) {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] <= target)
                {
                    start = mid;
                } else
                {
                    end = mid;
                }
            }
            if (nums[end] == target)
            {
                return end;
            }
            if (nums[start] == target)
            {
                return start;
            }
            return -1;
        }
    }
}
