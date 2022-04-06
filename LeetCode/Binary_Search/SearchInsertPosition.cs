using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class SearchInsertPosition
    {
        public static int Solution()
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 7;
            int minEl = 0;
            int maxEl = nums.Length - 1;

            bool arrayContain = nums.Any(x => x == target);

            while (minEl <= maxEl)
            {
                int mid = (minEl + maxEl) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    maxEl = mid - 1;
                }
                else
                {
                    minEl = mid + 1;
                }

            }

            return minEl;
        }
    }
}
