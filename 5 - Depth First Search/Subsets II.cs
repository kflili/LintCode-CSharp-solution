using System;
using System.Collections;
using System.Collections.Generic;

namespace subsetsWithDup
{
    public class Solution
    {
        /*
         * @param nums: A set of numbers.
         * @return: A list of lists. All valid subsets.
        */
        public List<List<int>> subsetsWithDup(int[] nums)
        {
            List<List<int>> results = new List<List<int>>();
            if (nums == null) {
                return results;
            }
            List<int> subset = new List<int>();
            if (nums.Length == 0) {
                results.Add(subset);
                return results;
            }
            Array.Sort(nums);
            helper(nums, 0, subset, results);
            return results;
        }
        private void helper(int[] nums, int startIndex, List<int> subset, List<List<int>> results) {
            results.Add(subset);
            for (int i = startIndex; i < nums.Length; i++) {
                if (i != startIndex && nums[i] == nums[i - 1]) {
                    continue;
                }
                subset.Add(nums[i]);
                helper(nums, i + 1, subset, results);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }

}