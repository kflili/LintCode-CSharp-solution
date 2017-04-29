using System;

namespace codeTest
{
    /**
    * public class SVNRepo {
    *     public static boolean isBadVersion(int k);
    * }
    * you can use SVNRepo.isBadVersion(k) to judge whether 
    * the kth code version is bad or not.
    */
    public class FindFirstBadVersionSolution
    {
        /**
        * @param n: An integers.
        * @return: An integer which is the first bad version.
        */
        public int FindFirstBadVersion(int n)
        {
            int start = 1, end = n;
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (SVNRepo.isBadVersion(mid))
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            return SVNRepo.isBadVersion(start) ? start : end;
        }
    }
}