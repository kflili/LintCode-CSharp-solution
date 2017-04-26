using System;

namespace codeTest
{
    /** 
    *@param A : an integer rotated sorted array
    *@param target :  an integer to be searched
    *return : an integer
    */   
    public class Solution
    {
        public int search (int[] A, int target) {
            if (A == null || A.Length == 0) {
                return -1;
            }
            int start = 0, end = A.Length - 1;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (A[mid] == target)
                {
                    return mid;
                }
                if (A[mid] < A[A.Length - 1])
                {
                    // lower part
                    if (A[mid] < target && target < A[end])
                    {
                        start = mid;
                    } else
                    {
                        end = mid;
                    }
                } else
                {
                    if (A[start] < target && target < A[mid])
                    {
                        end = mid;
                    } else
                    {
                        start = mid;
                    }
                }
            }
            if (A[start] == target)
            {
                return start;
            }
            if (A[end] == target)
            {
                return end;
            }
            return -1;
        }
    }
}