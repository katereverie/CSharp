using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.BLL
{
    public class LogicExercises
    {
        /* The number 6 is a truly great number. Given two int values, a and b, return true if either one is 6. 
         * Or if their sum or difference is 6.
        */
        public static bool LoveSix(int a, int b)
        {
            if ((a == 6 || b == 6) || (a + b == 6) || (a - b ==6) || (b - a == 6))
            {
                return true;
            }
            return false;
        }

        /* You and your date are trying to get a table at a restaurant. The 
         * parameter "yourStyle" is the stylishness of your clothes, in the range 0..10, 
         * and "dateStyle" is the stylishness of your date's clothes. The result getting 
         * the table is encoded as an int value with 0=no, 1=maybe, 2=yes. 
         * 
         * If either of you is very stylish, 8 or more, then the result is 2 (yes). 
         * With the exception that if either of you has style of 2 or less, then the result is 0 (no). 
         * Otherwise the result is 1 (maybe). 
        */
        public static int CanHazTable(int yourStyle, int dateStyle) 
        {
            if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else
            {
                if (yourStyle >= 8 || dateStyle >= 8)
                {
                    return 2;
                }

                return 1;
            }
        }

        /* The children in Cleveland spend most of the day playing outside. In particular, 
         * they play if the temperature is between 60 and 90 (inclusive). Unless it is summer, 
         * then the upper limit is 100 instead of 90. Given an int temperature and a bool isSummer, 
         * return true if the children play and false otherwise.
        */
        public static bool PlayOutside(int temp, bool isSummer) 
        {
            if (isSummer)
            {
                if (temp >= 60 && temp <= 100)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (temp >= 60 && temp <= 90)
                {
                    return true;
                }
                return false;
            }
        }

        /* You are driving a little too fast, and a police officer stops you. Write code to compute 
         * the result, encoded as an int value: 0=no ticket, 1=small ticket, 2=big ticket. 
         * 
         * If speed is 60 or less, the result is 0. 
         * If speed is between 61 and 80 inclusive, the result is 1. 
         * If speed is 81 or more, the result is 2. 
         * 
         * Unless it is your birthday -- on that day, your speed can be 5 higher in all cases.
        */
        public static int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday)
            {
                speed -= 5;
            }
            if (speed <= 60)
            {
                return 0;
            }
            if (speed >=61 && speed <= 80)
            {
                return 1;
            }
            return 2;
        }

        /* Given 2 ints, a and b, return their sum. However, sums in the range 10..19 inclusive are forbidden, 
         * so in that case just return 20. 
        */
        public static int SkipSum(int a, int b) 
        {
            int sum = a + b;
            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }
            return sum;
        }

        /* Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, and a boolean indicating if we are 
         * on vacation, return a string of the form "7:00" indicating when the alarm clock should ring. Weekdays, 
         * the alarm should be "7:00" and on the weekend it should be "10:00". Unless we are on vacation -- then 
         * on weekdays it should be "10:00" and weekends it should be "off". 
        */
        public static string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                if (day == 6 || day == 7)
                {
                    return "off";
                }
                return "10:00";
            }
            if (day == 6 || day == 7)
            {
                return "10:00";
            } 
            else
            {
                return "7:00";
            }
        }

        /* Given a number n, return true if n is in the range 1..10, inclusive. Unless "outsideMode" is true, 
         * in which case return true if the number is less than or equal to 1, or greater than or equal to 10.
        */
        public static bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
            {
                if (n <= 1 || n >= 10)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if ( n >= 1 && n <= 10)
                {
                    return true;
                }
                return false;
            }
        }

        /* We'll say a number is special if it is a multiple of 11 or if it is one more than a multiple of 11. 
         * Return true if the given non-negative number is special. Use the % "mod" operator
        */
        public static bool SpecialEleven(int n)
        {
            if (n % 11 == 0 || n % 11 == 1)
            {
                return true;
            }
            return false;
        }

        /* Return true if the given non-negative number is 1 or 2 more than a multiple of 20. 
         * Use the % "mod" operator
        */
        public static bool Mod20(int n)
        {
            if ( n % 20 == 1 || n % 20 == 2)
            {
                return true;
            }
            return false;
        }

        /* Return true if the given non-negative number is a multiple of 3 or 5, but not both. 
         * Use the % "mod" operator
        */
        public static bool Mod35(int n)
        {
            if ( (n % 3 == 0 || n % 5 == 0) && n % 15 != 0)
            {
                return true;
            }
            return false;
        }

        /* Your cell phone rings. Return true if you should answer it. Normally you answer, 
         * except in the morning you only answer if it is your mom calling. 
         * In all cases, if you are asleep, you do not answer.
        */
        public static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            } 
            else if (!isAsleep && isMorning)
            {
                if (isMom)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        /* Given three ints, a b c, return true if it is possible to add any two of the ints 
         * to get the third. 
        */
        public static bool TwoIsOne(int a, int b, int c)
        {
            if ( a + b == c || a + c == b || b + c == a)
            {
                return true;
            }
            return false;
        }

        /* This one is tricky! Given three ints, a b c, return true if two or more of them have 
         * the same rightmost digit. The ints are non-negative.
        */
        public static bool LastDigit(int a, int b, int c)
        {
            string A = a.ToString();
            char rA = A[A.Length - 1];
            string B = b.ToString();
            char rB = B[B.Length - 1];
            string C = c.ToString();
            char rC = C[C.Length - 1];

            if (rA != rB && rA != rC && rB != rC)
            {
                return false;
            }
            return true;
        }
    }
}
