using System;

namespace MountainSequence
{
    public class Solution
    {
        /**
         * @param nums a mountain sequence which increase firstly and then decrease
         * @return then mountain top
         */
        public int MountainSequence(int[] nums)
        {
            int left = 0, right = nums.Length;
            while (left + 1 < right)
            {
                int m1 = left + (right - left) / 2;
                int m2 = right - (right - m1) / 2;
                if (nums[m1] < nums[m2])
                {
                    left = m1;
                } else if (nums[m1] > nums[2])
                {
                    right = m2;
                } else
                {
                    left = m1;
                    right = m2;
                }
            }
            return nums[left] > nums[right] ? nums[left] : nums[right];
        }
    }
}
