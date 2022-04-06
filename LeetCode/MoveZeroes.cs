using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MoveZeroes
    {
        public static void Solution()
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };

            #region Z kopiowaniem tablicy
            //Queue<int> queue = new Queue<int>();
            //int i = 0;

            //foreach (var number in nums)
            //{
            //    if (number == 0)
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        queue.Enqueue(number);
            //    }
            //}

            //List<int> list = queue.ToList();

            //for (int j = 0; j < i; j++)
            //{
            //    list.Add(0);
            //}

            //for (int k = 0; k < nums.Length; k++)
            //{
            //    nums[k] = list[k];
            //}
            #endregion

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) continue;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == 0) continue;
                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                    break;
                }
            }
        }
    }
}
