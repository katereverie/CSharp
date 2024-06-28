using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.BLL
{
    public class ConditionalExercises
    {
        /* We have two children, a and b, and the parameters aSmile and bSmile indicate 
         * if each is smiling. We are in trouble if they are both smiling or if neither of 
         * them is smiling. 
         * 
         * Return true if we are in trouble. 
        */
        public static bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if ((aSmile && bSmile) || (!aSmile && !bSmile)) {
                return true;
            }
            return false;
        }

        /* The parameter weekday is true if it is a weekday, and the parameter vacation is true 
         * if we are on vacation. We sleep in if it is not a weekday or we're on vacation. 
         * 
         * Return true if we sleep in. 
        */
        public static bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday || isVacation)
            {
                return true;
            }
            return false;
        }

        /* Given two int values, return their sum. However, if the two values are the same, 
         * then return double their sum. 
        */
        public static int SumDouble(int a, int b)
        {
            if ( a == b )
            {
                return (a + b) * 2;
            }
            return a + b;
        }

        /* Given an int n, return the absolute value of the difference between n and 21, 
         * except return double the absolute value of the difference if n is over 21. 
        */
        public static int Diff21(int n)
        {
            int absDiff = Math.Abs(n - 21);
            if (n > 21)
            {
                return absDiff * 2;
            }
            return absDiff;
        }

        /* We have a loud talking parrot. The "hour" parameter is the current hour time in 
         * the range 0..23. We are in trouble if the parrot is talking and the hour is before 
         * 7 or after 20. 
         * 
         * Return true if we are in trouble.
        */
        public static bool ParrotTrouble(bool isTalking, int hour)
        {
            if ( isTalking && (hour < 7 || hour > 20)) 
            { 
                return true;
            }
            return false;
        }

        /* Given two ints, a and b, return true if one if them is 10 or if their sum is 10. */
        public static bool Makes10(int a, int b)
        {
            if ((a == 10 || b == 10) || (a + b) == 10)
            {
                return true;
            } 
            return false;
        }

        /* Given an int n, return true if it is within 10 of 100 or 200.
         * Hint: Check out the C# Math class for absolute value
        */
        public static bool NearHundred(int n)
        {
            if ( n < 0 )
            {
                return false;
            }
            else
            {
                 if ( Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10 )
                {
                    return true;
                }
                 return false;
            }
        }

        /* Given two int values, return true if one is negative and one is positive. 
         * Except if the parameter "negative" is true, then return true only if both are negative. 
        */
        public static bool PosNeg(int a, int b, bool negative)
        {
            if (negative)
            {
                if (a < 0 && b < 0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if ((a < 0 && b > 0) || (a > 0 && b < 0))
                {
                    return true;
                }
                return false;
            }

        }
        /* Given a string, return a new string where "not " has been added to the front. However, 
         * if the string already begins with "not", return the string unchanged.
         * 
         * Hint: You can use Substring or StartsWith in C#
        */
        public static string NotString(string s)
        {
            if (s.StartsWith("not"))
            {
                return s;
            }
            return "not " + s;
        }

        /* Given a non-empty string and an int n, return a new string where the char at index n has 
         * been removed. The value of n will be a valid index of a char in the original string 
         * 
         * (Don't check for bad index).
        */
        public static string MissingChar(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(n+1);
        }

        /* Given a string, return a new string where the first and last chars have been exchanged. */
        public static string FrontBack(string str)
        {
            char last = str[str.Length - 1];
            char first = str[0];
            if (str.Length == 1)
            {
                return str;
            } 
            if (str.Length == 2)
            {
                return $"{last}{first}";
            }
            return $"{last}{str.Substring(1, str.Length - 2)}{first}";
        }

        /* Given a string, we'll say that the front is the first 3 chars of the string. If the string 
         * length is less than 3, the front is whatever is there. Return a new string which is 3 copies 
         * of the front. 
         */
        public static string Front3(string str)
        {
            if (str.Length < 3)
            {
                return str.Substring(0) + str.Substring(0) + str.Substring(0);
            } 
            return str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
        }

        /* Given a string, take the last char and return a new string with the last char added at the 
         * front and back, so "cat" yields "tcatt". 
         * 
         * The original string will be length 1 or more. 
        */
        public static string BackAround(string str)
        {
            char last = str[str.Length-1];
            return last + str + last;
        }

        /* Return true if the given non-negative number is a multiple of 3 or a multiple of 5. 
         * 
         * Use the % "mod" operator
        */
        public static bool Multiple3or5(int n)
        {
            if ( n % 3 == 0 || n % 5 == 0 )
            {
                return true;
            }
            return false;
        }

        /* Given a string, return true if the string starts with "hi" and false otherwise. */
        public static bool StartHi(string str)
        {
            if (str.StartsWith("hi"))
            {
                return true;
            }
            return false;
        }
    }
}
