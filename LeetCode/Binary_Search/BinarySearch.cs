using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Binary_Search
{
    public static class BinarySearch
    {
        public static void Solution()
        {
            //https://www.c-sharpcorner.com/blogs/binary-search-implementation-using-c-sharp1

            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = 9;

            int minNum = 0;
            int maxNum = nums.Length - 1;

            // needed if array wasnt sorted
            // Array.Sort(nums);

            while(minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (target == nums[mid])
                {
                    Console.WriteLine($"{target} found at index {++mid}");
                    break;
                }
                else if (target < nums[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            Console.ReadKey();
        }
    }
}
