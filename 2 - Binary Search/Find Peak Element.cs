using System;

namespace codeTest
{
    /**
     * @param A: An integers array.
     * @return: return any of peek positions.
     */
    public class Solution
    {
        public int FindPeak(int[] A)
        {
            // 1, 答案必然在1和n-2之间，除去0和n-1
            // 2, 设定1， n-2 在后边mid - 1 的时候防止 0-1 的越界情况
            int start = 1, end = A.Length - 2;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (A[mid] > A[mid - 1])
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }
            return A[start] > A[end] ? start : end;
        }
    }
}
