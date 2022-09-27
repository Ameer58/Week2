using System;
using System.Linq;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            int compare = DateTime.Compare(birthDate, date);
            if (compare >= 0) throw new ArgumentException("Error - birthDate is in the future");
            if (birthDate.Month > date.Month) return date.Year - 1  - birthDate.Year ;
            return date.Year - birthDate.Year;
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {

            return date.ToLongDateString();
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToLongDateString().Split(' ').Skip(1).FirstOrDefault();
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            if (suit == Suit.HEARTS) return "You've broken my heart";
            if (suit == Suit.CLUBS) return "And the seventh rule is if this is your first night at fight club, you have to fight.";
            if (suit == Suit.DIAMONDS) return "Diamonds are a girls best friend";
            if (suit == Suit.SPADES) return "Bucket and spade";
            return string.Empty;
        }
    }
}
