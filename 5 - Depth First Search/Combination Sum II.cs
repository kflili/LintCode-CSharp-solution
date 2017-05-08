using System;
using System.Collections;
using System.Collections.Generic;

namespace CombinationSum2
{
    public class Solution
    {
        /* 
        * @param num: Given the candidate numbers
        * @param target: Given the target number
        * @return: All the combinations that sum to target
        */
        public List<List<int>> CombinationSum2(int[] num, int target)
        {
            List<List<int>> results = new List<List<int>>();
            if (num == null || num.Length == 0)
            {
                return results;
            }
            Array.Sort(num);
            List<int> combination = new List<int>();
            helper(num, 0, target, combination, results);
            return results;
        }
        private void helper(int[] num,
            int startIndex,
            int leftTarget,
            List<int> combination,
            List<List<int>> results)
        {
            if (num[startIndex] == leftTarget) {
                results.Add(new List<int>(combination));
                return;
            }
            for (int i = startIndex; i < num.Length; i++)
            {
                if (num[i] > leftTarget) {
                    return;
                }
                if (i != startIndex && num[i] == num[i - 1]) {
                    combination.Add(num[i]);
                    helper(num, i + 1, leftTarget - num[i], combination, results);
                    combination.RemoveAt(combination.Count - 1);
                }    
            }
        }
    }
}