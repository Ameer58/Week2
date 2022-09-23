using System;
using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {   
            double sum = 0;
            if(nums.Count <= 0) throw new ArgumentOutOfRangeException(nums.Count + "Invalid List");
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            double average = sum / nums.Count;
            return average;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {   
            if(age < 0) throw new ArgumentOutOfRangeException(age + "Not a valid age");
            string ticketType = string.Empty;
            if (age < 5) ticketType = "Free";
            else if (age <= 12) ticketType = "Child";
            else if (age <= 17) ticketType = "Student";
            else if (age <= 59) ticketType = "Standard";
            else ticketType = "OAP";

            return ticketType;
        }

        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100) throw new ArgumentOutOfRangeException(mark + "Invalid mark, 0-100");
            var grade = "";
            if (mark > 74)
                grade = "Pass with Distinction";
            else if (mark > 59)
                grade = "Pass with Merit";
            else if (mark > 39)
                grade = "Pass";
            else
                grade = "Fail";
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {   
            if(covidLevel < 0 || covidLevel > 4) throw new ArgumentOutOfRangeException(covidLevel + "Invalid level, 0-4");
            int attendes = 0;
            switch (covidLevel)
            {
                case 0:
                    attendes = 200;
                    break;
                case 1:
                    attendes = 100;
                    break;
                case 2:
                    attendes = 50;
                    break;
                case 3:
                    attendes = 50;
                    break;
                case 4:
                    attendes = 20;
                    break;


            }
            return attendes;
        }
    }
}
