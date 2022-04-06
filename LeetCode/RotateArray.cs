using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RotateArray
    {
        public static void Solution()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 8;

            k = k % nums.Length;

            ReverseArray(nums, 0, nums.Length - 1);
            ReverseArray(nums, 0, k - 1);
            ReverseArray(nums, k, nums.Length - 1);

            Console.Write("[ ");
            foreach (var number in nums)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }

        private static void ReverseArray(int[] array, int start, int end)
        {
            int x = start;
            int y = end;
            while (x <= y)
            {
                int tmp = array[x];
                array[x] = array[y];
                array[y] = tmp;
                x++;
                y--;
            }

        }

    }
}
