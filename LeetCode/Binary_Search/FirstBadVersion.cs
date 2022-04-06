using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class FirstBadVersion
    {
        public static bool IsBadVersion(int version)
        {
            switch(version)
            {
                case 1:
                    return true;
                case 2:
                    return true;
                case 3:
                    return true;
                default:
                    return false;
            }
        }

        public static int Solution(int n)
        {

            var startIndex = 1;
            var endIndex = n;

            return CheckForFirstBadVersion(startIndex, endIndex);
        }

        public static int CheckForFirstBadVersion(int startIndex, int endIndex)
        {
            var mid = 0;
            var ans = -1;

            while (startIndex <= endIndex)
            {
                mid = endIndex + (startIndex - endIndex) / 2;

                if (IsBadVersion(mid))
                {
                    ans = mid;
                    endIndex = mid - 1;
                }
                else
                {
                    startIndex = mid + 1;
                }

            }

            return ans;

            //int start = 1;
            //int end = n;
            //int ans = 0;
            //while (start <= end)
            //{
            //    int mid = start + (end - start) / 2;

            //    if (isBadVersion(mid))
            //    {
            //        ans = mid;
            //        end = mid - 1;
            //    }
            //    else
            //    {
            //        start = mid + 1;
            //    }
            //}
            //return ans;
        }


    }
}
