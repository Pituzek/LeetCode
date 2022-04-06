using System;
using LeetCode;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = 1;

            //var str = "10";
            //var b = 5;
            //var s = str + b;

            while (output == 1)
            {
                Console.WriteLine("Wybierz zadanie");

                Console.WriteLine(" 1 - Roman number to integer (converter)");
                Console.WriteLine(" 2 - Binary search");
                Console.WriteLine(" 3 - First bad version");
                Console.WriteLine(" 4 - Search insert position");
                Console.WriteLine(" 5 - Squares of a sorted array");
                Console.WriteLine(" 6 - Rotate array");
                Console.WriteLine(" 7 - Move Zeroes");

                Console.WriteLine(" 99 - exit");

                int userInput = int.Parse(Console.ReadLine());

                switch(userInput)
                {
                    case 1:
                        Console.Clear();
                        Roman_numbers.RomanToInteger.Solution();
                        break;
                    case 2:
                        Console.Clear();
                        Binary_Search.BinarySearch.Solution();
                        break;
                    case 3:
                        Console.Clear();
                        Binary_Search.FirstBadVersion.Solution(5);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine( 
                            Binary_Search.SearchInsertPosition.Solution());
                        break;
                    case 5:
                        Console.Clear();
                        SquaresOfASortedArray.Solution();
                        break;
                    case 6:
                        Console.Clear();
                        RotateArray.Solution();
                        break;
                    case 7:
                        Console.Clear();
                        MoveZeroes.Solution();
                        break;
                    default:
                        output = -1;
                        break;
                }

            }
        }
    }
}
