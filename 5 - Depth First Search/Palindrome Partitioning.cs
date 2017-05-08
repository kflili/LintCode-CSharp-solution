using System;
using System.Collections;
using System.Collections.Generic;

namespace PalindromePartition
{
    public class Solution
    {
        /* 
        @param s: A string
        @return: A list of lists of string
        */
        public List<List<string>> Partition(string s)
        {
            List<List<string>> results = new List<List<string>>();
            if (s == null || s.Length == 0)
            {
                return results;
            }
            List<string> partition = new List<string>();
            helper(s, 0, partition, results);
            return results;
        }
        private void helper(string s,
            int startIndex,
            List<string> partition,
            List<List<string>> results)
        {
            if (startIndex == s.Length) {
                results.Add(new List<string>(partition));
            }
            for (int i = startIndex; i < s.Length; i++)
            {
                string subString = s.Substring(startIndex, i - startIndex + 1);
                if (!isPalindrome(subString))
                {
                    continue;
                }
                partition.Add(subString);
                helper(s, i + 1, partition, results);
                partition.RemoveAt(partition.Count - 1);
            }
        }
        private bool isPalindrome (string s) {
            for (int i = 0, j = s.Length; i < j; i++, j--) {
                if (s[i] != s[j]) {
                    return false;
                }
            }
            return true;
        }
    }
}