using System;

namespace SearchMatrix
{
    public class Solution
    {
        /**
         * @param matrix, a list of lists of integers
         * @param target, an integer
         * @return a boolean, indicate whether matrix contains target
         */
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }
            if (matrix[0] == null || matrix[0].Length == 0)
            {
                return false;
            }
            int row = matrix.Length;
            int col = matrix[0].Length;
            int start = 0;
            int end = row * col - 1;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                int midNum = getNum(matrix, mid);
                if (target == midNum)
                {
                    return true;
                }
                else if (target < midNum)
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            if (target == getNum(matrix, start))
            {
                return true;
            }
            if (target == getNum(matrix, end))
            {
                return true;
            }
            return false;
        }
        public int getNum(int[][] mat, int index)
        {
            int r = mat.Length;
            int c = mat[0].Length;
            return mat[index / c][index % c];  // very important!!!!
        }
    }
}
