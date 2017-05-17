using System;
using System.Collections;
using System.Collections.Generic;

namespace deduplication
{
    public class Solution
    {
        public int deduplication(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            Array.Sort(nums);
            int slow = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[slow])
                {
                    nums[++slow] = nums[i];
                }
            }
            return slow + 1;
        }
    }
}
