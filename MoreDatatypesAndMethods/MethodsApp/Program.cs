namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = DoThis(10, "Enthused");
            var result2 = DoThis(25);
            var pizza1 = OrderPizza(true, false, true);

            var myTuple = ("Joe", "Bloggs", 25);
            Console.WriteLine(myTuple);
            Console.WriteLine(myTuple.Item2);
        }

        public static int DoThis(int x, string y = "Happy")
        {
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }

        public static string OrderPizza(bool anchovies, bool pineapple, bool mushrooms = false)
        {
            var pizza = "Pizza with tomato sauce, cheese, ";
            if (anchovies) pizza += "anchovies, ";
            if (anchovies) pizza += "pineapple, ";
            if (anchovies) pizza += "mushrooms, ";
            return pizza;
        }
    }
}