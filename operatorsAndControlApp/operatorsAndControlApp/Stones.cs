using System;
using System.Collections.Generic;
using System.Text;

namespace operatorsAndControlApp
{
    public class Stones
    {
        public static int GetStones(int totalPounds)
        {
            int stones = totalPounds/14;
            return stones;
        }

        public static int GetPounds(int totalPounds)
        {
            int pounds = totalPounds % 14;
            return pounds;
        }

    }
}
