using System;
using System.Collections.Generic;
using System.Text;

namespace operatorsAndControlApp
{
    public class Stones
    {
        public static int GetStones(int totalPounds)
        {   
            if(totalPounds <= 0)
            {
                throw new ArgumentOutOfRangeException(totalPounds + "Is not a valid weight");
            }
            int stones = totalPounds/14;
            return stones;
        }

        public static int GetPounds(int totalPounds)
        {
            if (totalPounds <= 0)
            {
                throw new ArgumentOutOfRangeException(totalPounds + "Is not a valid weight");
            }
            int pounds = totalPounds % 14;
            return pounds;
        }

    }
}
