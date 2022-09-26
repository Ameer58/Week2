using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharpIntroductionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Swap(ref x,ref y);
            Console.WriteLine("X:"+x+" Y:"+y);

        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y; y = temp;
        }
    }
}
