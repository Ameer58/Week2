using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace MoreDatatypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var myString = "  C# list fundamentals ";
            //Console.WriteLine(StringBuilderExercise(myString))
            int scoreA = 2;
            int scoreB = 1; 
            string concatString1 = "Liverpool : " + scoreA + ", Manchester United : " + scoreB;

            string concatString2 = String.Concat("Liverpool : ", scoreA, ", Manchester United : ", scoreB);

            StringInterpolation("Cathy");
           
        
        }
        public static void StringInterpolation(string str)
        {
            Console.WriteLine("My name is : " + str + " using +");
            Console.WriteLine($"My name is: {str} using interpolation");
            var num1 = 2;
            var num2 = 7;
            var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
            Console.WriteLine(fString);

            var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1):0.####}";
            var fString3 = $"That will be {num2 / 3.0:c} please!";
            ParsingStrings();
        }

        public static string StringExercise(string myString)
        {
            string iString = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
            var x = iString.IndexOf('N');
            return iString.Remove(x + 1);
        }    
        public static string StringBuilderExercise(string myString)
        {
            StringBuilder sb = new StringBuilder(myString);

            sb.Replace('l', '*').Replace('t', '*').Remove(myString.IndexOf('n')+1, sb.Length - myString.IndexOf('n')-1);
            return sb.ToString().Trim().ToUpper();

        }

        public static void ParsingStrings()
        {
            // parsing strings    Console.WriteLine("How many apples?");
            Console.WriteLine("How many apples?");
            string input = Console.ReadLine();
            var succes = Int32.TryParse(input, out int parsedApples);
        }
    }
}