using System;

namespace unitTestLessonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int age = 119;
            Boolean adult = false;
            string output = AvailableClassifications(age, adult);
            Console.WriteLine(output);
        }

        public static string AvailableClassifications(int ageOfViewer, Boolean adult)
        {
            string result;
            if (ageOfViewer < 12 && adult.Equals(false))
            {
                result = "U & PG films are available.";
            }
            else if ((ageOfViewer < 12 && adult.Equals(true)) || ageOfViewer >= 12 & ageOfViewer < 15)
            {
                result = "U, PG & 12 films are available.";
            }
            else if(ageOfViewer < 18)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "All films are available.";
            }
            return result;
        }

        public static string GetGreeting(int timeOfDay)
        {
            
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                return "Good morning!";
            }
            else if (timeOfDay > 12 && timeOfDay <= 18)
            {
                return"Good afternoon!";
            }
            else
            {
                return"Good evening!";
            }
        }
    }
}
