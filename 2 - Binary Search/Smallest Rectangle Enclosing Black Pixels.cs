using System;

namespace MinArea
{
    /**
    * @param image a binary matrix with '0' and '1'
    * @param x, y the location of one of the black pixels
    * @return an integer
    */   
    public class Solution
    {
        public int MinArea (char[][] image, int x, int y) {
            if (image == null || image.Length == 0 || image[0].Length == 0)
            {
                return 0;
            }
            int row = image.Length;
            int col = image[0].Length;

            int left = FindLeft(image, 0, y);
            int right = FindRight(image, y, col - 1);
            int top = FindTop(image, 0, x);
            int bottom = FindBottow(image, x, row - 1);

            return (right - left + 1) * (bottom - top + 1);
        }
        private int FindLeft (char[][] image, int start, int end) {
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (isEmptyColumn(image, mid))
                {
                    start = mid;
                } else
                {
                    end = mid;
                }
            }
            if (isEmptyColumn(image, start))
            {
                return end;
            }
            return start;
        }
        private int FindRight (char[][] image, int start, int end) {
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (isEmptyColumn(image, mid))
                {
                    end = mid;
                } else
                {
                    start = mid;
                }
            }
            if (isEmptyColumn(image, end))
            {
                return start;
            }
            return end;
        }
        private bool isEmptyColumn(char[][] image, int col) {
            for (int i = 0; i < image.Length; i++)
            {
                if (image[i][col] == '1')
                {
                    return false;
                }
            }
            return true;
        }
        private int FindTop (char[][] image, int start, int end) {
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (isEmptyRow(image, mid))
                {
                    start = mid;
                } else
                {
                    end = mid;
                }
            }
            if (isEmptyRow(image, start))
            {
                return end;
            }
            return start;
        }
        private int FindBottow (char[][] image, int start, int end) {
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (isEmptyRow(image, mid))
                {
                    end = mid;
                } else
                {
                    start = mid;
                }
            }
            if (isEmptyRow(image, end))
            {
                return start;
            }
            return end;
        }
        private bool isEmptyRow (char[][] image, int row) {
            for (int i = 0; i < image.Length; i++)
            {
                if (image[row][i] == '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}