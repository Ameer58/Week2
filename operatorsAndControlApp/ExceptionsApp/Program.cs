using System;
using System.IO;

namespace ExceptionsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("A's marks is 82:" + Grade(82));
                Console.WriteLine("B's marks is -82:" + Grade(-82));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid data, try again");
                Console.WriteLine(e.Message);
            }
        }
        public static string Grade(int mark)
        {   
            if(mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark:" + mark + "Allowed range 0-100");
            }
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }   
    }
}

