using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {   
            if(num > short.MaxValue) throw new OverflowException();
            return (short)num;
        }

        public static long FloatToLong(float num)
        {
            num = MathF.Round(num);
            return (long)num;
        }
    }
}
