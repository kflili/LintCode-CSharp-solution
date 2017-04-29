using System;

namespace strStr
{
    public class Solution
    {
        /*
        For a given source string and a target string, you should output the first 
        index(from 0) of target string in source string. If target does not exist 
        in source, just return -1.
        Example:
        If source = "source" and target = "target", return -1.
        If source = "abcdabcdefg" and target = "bcd", return 1.
        */
        public int strStr(string source, string target)
        {
            if (source == null || target == null)
            {
                return -1;
            }
            for (int i = 0; i < source.Length - target.Length + 1; i++)
            {
                int j = 0;
                for (j = 0; j < target.Length; j++)
                {
                    if (source[i + j] != target[j])
                    {
                        break;
                    }
                }
                if (j == target.Length)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
