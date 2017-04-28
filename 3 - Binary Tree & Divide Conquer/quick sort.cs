using System;

namespace codeTest
{
    public class Solution
    {
        public void SortIntegers (int[] A) {
            QuickSort(A, 0, A.Length - 1);
        }
        private void QuickSort (int[] A, int start, int end) {
            if (start >= end)
            {
                return;
            }
            int left = start, right = end;
            //key point 1: pivot is the value, not the index
            int pivot = A[(start + end) / 2];
            
            // key point 2: every time you compare left & right, it should be
            // left <= right, not left < right
            while (left <= right)
            {
                // key point 3: A[left] < pivot, not A[left] <= pivot
                while (left <= right && A[left] < pivot)
                {
                    left++;
                }
                while (left <= right && A[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;
                    left++;
                    right--;
                }
            }
            QuickSort(A, start, right);
            QuickSort(A, left, end);
        }
    }
}