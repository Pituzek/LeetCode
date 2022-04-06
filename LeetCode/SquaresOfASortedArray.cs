using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class SquaresOfASortedArray
    {
        public static void Solution()
        {
            int[] input = new int[] { -4, -1, 0, 3, 10 };

            int x = 0, y = input.Length - 1;
            Stack<int> stack = new Stack<int>();
            while (x <= y)
            {
                if (Math.Abs(input[x]) <= Math.Abs(input[y]))
                {
                    stack.Push(input[y] * input[y]);
                    y--;
                }
                else
                {
                    stack.Push(input[x] * input[x]);
                    x++;
                }
            }

            int[] output = stack.ToArray();


            //int[] nums = new int[] { -4, -1, 0, 3, 10 };
            ////int[] tmp = new int[nums.Length];


            //for (int i = nums.Length - 1; i >= 0; i--)
            //{
            //    nums[i] = (int)(Math.Pow(nums[i], 2));
            //}

            //int temp;
            //// bubble sort ma miec dwie petle for
            //for (int i = 0; i < nums.Length - 2; i++)
            //{
            //    for (int j = 0; j < nums.Length - 2; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            temp = nums[j + 1];
            //            nums[j + 1] = nums[j];
            //            nums[j] = temp;
            //        }

            //    }
            //}

            //return tmp;
        }
    }
}
