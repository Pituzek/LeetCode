using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class TwoSumII_InputArrayIsSorted
    {
        public static int[] Solution()
        {
            int[] numbers = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new int[2] { left + 1, right + 1 };
                }

                if (target < sum)
                {
                    right--;
                }
                else
                {
                    left++;
                }

            }

            return null;
        }
    }
}
