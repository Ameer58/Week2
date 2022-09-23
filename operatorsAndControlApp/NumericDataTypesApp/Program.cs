using System;
using System.ComponentModel.DataAnnotations;

namespace NumericDataTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 65.12412415;
            double y = (float)x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            int numCows = 260;
            uint countCows = (uint)numCows;
            byte byteCows = (byte)numCows;

            int bankBalance = -2;
            uint posBalance = (uint)bankBalance;
            Console.WriteLine(Convert.ToString(bankBalance, 2));
            Console.WriteLine(Convert.ToString(posBalance, 2));

            //float pi = 3.14f;
            //bool boolPi = (bool)pi;
            //DateTime piDay = (DateTime)pi;

            //no conversion
            var intx = 5;
            var inty = Convert.ToInt32(x);

            //safe - widening

            //var myDouble = Convert.ToDouble(intx);

            //narrowing unsafe no data loss

            //var s = Convert.ToInt16(intx);
            double myPi = 3.14;
            //float floatPi = Convert.ToSingle(myPi);

            //unsafe with data loss
            //int myCows = 260;
            //byte mybyteCows = Convert.ToByte(myCows);

            //int myBankBalance = -2;
            //uint myPosBalance = Convert.ToUInt32((uint)myBankBalance);
            
            int myFive =Convert.ToInt32("5");
            byte num = Byte.MaxValue;
            Console.WriteLine("Byte max: " + num);
            num += 1;
            Console.WriteLine(num);
        }
    }
}
