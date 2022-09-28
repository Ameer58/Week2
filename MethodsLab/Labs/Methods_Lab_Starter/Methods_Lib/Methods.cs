using System;
using System.Diagnostics.CodeAnalysis;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            int day = totalDays % 7;
            int weeks = totalDays / 7;
            return (weeks, day);

        }

        public static(int square, int cube, double root) PowersRoot(int num)
        {
            if (num < 0) throw new ArgumentException();
            int square = num * num;
            int cube = square * num;
            double root = Math.Sqrt(num);
            return (square,cube,root);
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
