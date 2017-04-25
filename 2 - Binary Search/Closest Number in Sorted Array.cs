using System;

namespace closestNumber
{
    public class Solution
    {
        public int closestNumber(int[] A, int target) {
            if (A == null || A.Length == 0)
            {
                return -1;
            }
            int start = 0;
            int end = A.Length - 1;
            int mid = 0;
            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (target == A[mid])
                {
                    return mid;
                } else if (target < A[mid])
                {
                    end = mid;
                } else
                {
                    start = mid;
                }
            }
            if (Math.Abs(A[start] - target) < Math.Abs(A[end] - target))
            {
                return start;
            } else
            {
                return end;
            }
        }
    }
}
