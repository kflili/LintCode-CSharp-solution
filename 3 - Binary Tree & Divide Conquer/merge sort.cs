using System;

namespace codeTest
{
    public class MergeSortSolution
    {
        public void SortIntegers (int[] A) {
            // use a shared temp array, not in the helper method, more efficient
            // the extra memory is O(n) at least
            int[] temp = new int[A.Length];
            MergeSort(A, 0, A.Length - 1, temp);
        }
        private void MergeSort (int[] A, int start, int end, int[] temp) {
            if (start >= end)
            {
                return;
            }
            int mid = start + (end - start) / 2;
            MergeSort(A, start, mid, temp);
            MergeSort(A, mid + 1, end, temp);
            Merge(A, start, end, temp);
        }
        private void Merge (int[] A, int start, int end, int[] temp) {
            int mid = start + (end - start) / 2;
            int leftIndex = start;
            int rightIndex = mid + 1;
            int Index = start;
            while (leftIndex <= mid && rightIndex <= end)
            {
                if (A[leftIndex] < A[rightIndex])
                {
                    temp[Index++] = A[leftIndex++];
                } else
                {
                    temp[Index++] = A[rightIndex++];
                }
            }
            while (leftIndex <= mid)
            {
                temp[Index++] = A[leftIndex++];
            }
            while (rightIndex <= end)
            {
                temp[Index++] = A[rightIndex++];
            }
            // copy temp back to A
            for (int i = start; i <= end; i++)
            {
                A[i++] = temp[i++];
            }
        }
    }
}