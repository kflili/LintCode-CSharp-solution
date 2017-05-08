using System;
using System.Collections;
using System.Collections.Generic;

namespace CombinationSum
{
    public class Solution
    {
        /* 
        * @param num: Given the candidate numbers
        * @param target: Given the target number
        * @return: All the combinations that sum to target
        */
        public List<List<int>> CombinationSum(int[] candidates, int target)
        {
            List<List<int>> results = new List<List<int>>();
            if (candidates == null || candidates.Length == 0)
            {
                return results;
            }
            int[] nums = SortAndRemoveDuplicates(candidates);
            List<int> combination = new List<int>();
            helper(nums, 0, target, combination, results);
            return results;
        }
        private void helper(int[] nums,
            int startIndex,
            int leftTarget,
            List<int> combination,
            List<List<int>> results)
        {
            if (nums[startIndex] == leftTarget)
            {
                results.Add(new List<int>(combination));
                return;
            }
            for (int i = startIndex; i < nums.Length; i++)
            {
                if (nums[i] > leftTarget)
                {
                    return;
                }
                combination.Add(nums[i]);
                helper(nums, i, leftTarget - nums[i], combination, results);
                combination.RemoveAt(combination.Count - 1);
            }
        }

        private int[] SortAndRemoveDuplicates (int[] candidates) {
            Array.Sort(candidates);
            int index = 0;
            for (int i = 0; i < candidates.Length; i++) {
                if (candidates[index] != candidates[i]) {
                    candidates[++index] = candidates[i];
                }
            }
            int[] nums = new int[index + 1];
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = candidates[i];
            }
            return nums;
        }
    }
}