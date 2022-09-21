using System;

namespace operatorsAndControlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;
            //int a = x++;
            //int d = y++;

            int c = x / y;
            int d = x & y;

            var db1 = 5.0;
            var diveded = db1 / 2;
            PrintTimeToBirth(31);
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
