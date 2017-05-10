using System;
using System.Collections;
using System.Collections.Generic;

namespace permuteUnique
{
    public class Solution
    {
        public List<List<int>> permuteUnique(int[] nums) {
            List<List<int>> results = new List<List<int>>();
            if (nums == null) {
                return results;
            }
            List<int> list = new List<int>();
            if (nums.Length == 0) {
                results.Add(list);
                return results;
            }
            Array.Sort(nums);
            int[] visited = new int[nums.Length];
            for (int i = 0; i < visited.Length; i++) {
                visited[i] = 0;
            }
                helper(nums, visited, list, results);
            return results;
        }
        private void helper(int[] nums, int[] visited, List<int> list, List<List<int>> results) {
            if (list.Count == nums.Length) {
                results.Add(new List<int>(list));
                return;
            }
            for (int i = 0; i < nums.Length; i++) {
                if (visited[i] == 1 || (i != 0 && nums[i] == nums[i - 1] && visited[i - 1] == 0)) {
                    continue;
                }
                list.Add(nums[i]);
                visited[i] = 1;
                helper(nums, visited, list, results);
                visited[i] = 0;
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}