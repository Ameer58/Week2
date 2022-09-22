using System;
using System.Collections.Generic;

namespace operatorsAndControlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 2;
            //int a = x++;
            //int d = y++;

            // int c = x / y;
            //int d = x & y;

            //var db1 = 5.0;
            //var diveded = db1 / 2;
            PrintTimeToBirth(31);
            int mark = 35;
            var grade = mark >= 65 ? "Pass" : "Fail";

            List<int> nums = new List<int> { 10, 6, 22, 31, 4, -4 };
            Console.WriteLine("Highest foreach loop"+ LoopTypes.HighestForEachLoop(nums));
        }

        public static void PrintTimeToBirth(int days)
        {
            int weeks = days / 7;
            int d = days % 7;
            Console.Out.Write("Weeks:" + weeks + "Days:" + d);
        }
        public static Boolean IsEven(int n) => n % 2 == 0;

    }
}
