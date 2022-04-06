using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Roman_numbers
{
    public static class RomanToInteger
    {

        #region Examples
        /*
         * 
         Example 1:
         Input: s = "III"
         Output: 3
         Explanation: III = 3.

         Example 2:
         Input: s = "LVIII"
         Output: 58
         Explanation: L = 50, V= 5, III = 3.

         Example 3:
         Input: s = "MCMXCIV"
         Output: 1994
         Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
         * 
         */
        #endregion

        public static void Solution()
        {
            List<string> inputs = new List<string>() {
                "III",
                "LVIII",
                "MCMXCIV"
            };

            Dictionary<string, int> romanNumbers = new Dictionary<string, int>() {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000}
            };

            // hardcoded input
            count(inputs[2], romanNumbers);

            Console.ReadKey();
        }

        public static void count(string s, Dictionary<string, int> romanNumbers)
        {
            int sum = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentNum = 0;
                int previousNum = 0;
                romanNumbers.TryGetValue(s[i].ToString(), out currentNum);
                if (i < s.Length - 1) romanNumbers.TryGetValue(s[i + 1].ToString(), out previousNum);
                if (currentNum < previousNum) sum -= currentNum;
                else sum += currentNum;

            }
            Console.WriteLine($"Wynik: {sum}");
        }

    }
}
