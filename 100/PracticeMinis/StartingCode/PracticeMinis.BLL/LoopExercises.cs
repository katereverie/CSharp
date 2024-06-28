using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeMinis.BLL
{
    public class LoopExercises
    {
        /* Given a string and a non-negative int n, return a larger string 
         * that is n copies of the original string. */
        public static string StringTimes(string str, int n)
        {
            string newStr = "";
            while (n > 0)
            {
                newStr += str;
                n--;
            }
            return newStr;
        }

        /* Given a string and a non-negative int n, we'll say that the front of 
         * the string is the first 3 chars, or whatever is there if the string is less 
         * than length 3. Return n copies of the front; 
        */
        public static string FrontTimes(string str, int n)
        {
            string front;
            string newStr = "";
            if (str.Length < 3)
            {
                front = str;
            } 
            else
            {
                front = str.Substring(0, 3);
            }
            while (n > 0)
            {
                newStr += front;
                n--;
            }
            return newStr;
        }

        /* Count the number of "xx" in the given string. We'll say that overlapping is 
         * allowed, so "xxx" contains 2 "xx". 
        */
        public static int CountXX(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].ToString() == "x" && str[i + 1].ToString() == "x")
                {
                    count++;
                }
            }

            return count;
        }

        /* Given a string, return true if the first instance of "x" in the string is 
         * immediately followed by another "x". 
        */
        public static bool DoubleX(string str)
        {
            int index = 0;

            do
            {
                if (str[index].ToString() == "x")
                {
                    break;
                }
                index++;
            } while (true);

            if (str[index + 1].ToString() == "x")
            {
                return true;
            }
            return false;
        }

        /* Given a string, return a new string made of every other char starting with 
         * the first, so "Hello" yields "Hlo". 
        */
        public static string EveryOther(string str)
        {
            int index = 0;

            string newStr = "";
            do
            {
                newStr += str[index];
                index += 2;
            } while (index <= str.Length - 1);

            return newStr;
        }

        /* Given a non-empty string like "Code" return a string like "CCoCodCode".  
         * (first char, first two, first 3, etc) 
        */
        public static string StringSplosion(string str)
        {
            string newStr = "";
            for (int i = 0; i <= str.Length - 1; i++)
            {
                newStr += str.Substring(0, i + 1);
            }
            return newStr;

        }

        /* Given a string, return the count of the number of times that a substring 
         * length 2 appears in the string and also as the last 2 chars of the string, 
         * so "hixxxhi" yields 1 (we won't count the end substring). 
        */
        public static int CountLast2(string str)
        {
            string last2Chars = str.Substring(str.Length - 2);
            string searchStr = str.Substring(0, str.Length - 2);
            string charsToCompare;
            int count = 0;

            for (int i = 0; i < searchStr.Length - 1; i++)
            {
                charsToCompare = searchStr.Substring(i, 2);
                if (charsToCompare == last2Chars)
                {
                    count++;
                }
            } 

            return count;
        }

        /* Given an array of ints, return the number of 9's in the array. */
        public static int Count9(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    count++;
                }
            }
            return count;
        }

        /* Given an array of ints, return true if one of the first 4 elements in the 
         * array is a 9. The array length may be less than 4. 
        */
        public static bool ArrayFront9(int[] numbers)
        {
            int arrSize = numbers.Length;
            int index = 0;
            bool found = false;
            
            if (arrSize < 4)
            {
                do
                {
                    if (numbers[index] == 9)
                    {
                        found = true;
                        break;
                    }
                    index++;

                } while (index < arrSize);
            } else
            {
                do
                {
                    if (numbers[index] == 9)
                    {
                        found = true;
                        break;
                    }
                    index++;
                } while (index < 4);
            }
            return found;
        }

        /* Given an array of ints, return true if .. 1, 2, 3, .. appears in the 
         * array somewhere. 
        */
        public static bool Array123(int[] numbers)
        {
            bool found = false;
            int index = 0;
            do
            {
                
                if (numbers[index] == 1 && numbers[index + 1] == 2 && numbers[index + 2] == 3)
                {
                    found |= true;
                    break;
                }
                index++;
            } while (index <= numbers.Length - 3);
            return found;
        }

        /* Given 2 strings, a and b, return the number of the positions where they 
         * contain the same length 2 substring. So "xxcaazz" and "xxbaaz" yields 3, 
         * since the "xx", "aa", and "az" substrings appear in the same place in 
         * both strings. 
        */
        public static int SubStringMatch(string a, string b)
        {
            int maxSize = a.Length >= b.Length? b.Length : a.Length;
            int count = 0;

            for (int i = 0; i < maxSize - 1; i++)
            {
                if (a[i] == b[i] && a[i + 1] == b[i + 1])
                {
                    count++;
                }
            }
            return count;
        }

        /* Given a string, return a version where all the "x" have been removed.
         * Except an "x" at the very start or end should not be removed. 
        */
        public static string StringX(string str)
        {
            string strWithoutStartAndEnd = str.Substring(1, str.Length - 2);
            string firstChar = str[0].ToString();
            string lastChar = str[str.Length - 1].ToString();

            string newStr = strWithoutStartAndEnd.Replace("x", "");

            return firstChar + newStr + lastChar;
        }

        /* Given a string, return a string made of the chars at indexes 0,1, 4,5, 
         * 8,9 ... so "kittens" yields "kien". 
        */
        public static string AltPairs(string str)
        {
            string newStr = "";
            int strSize = str.Length;

            for (int i = 0; i <= 9; i++)
            {
                if (i > strSize - 1)
                {
                    break;
                }
                else
                {
                    if (i == 0 || i == 1 || i == 4 || i == 5 || i == 8 || i == 9)
                    {
                        newStr += str[i];
                    }
                }
            }
            return newStr;
        }

        /* Suppose the string "yak" is unlucky. Given a string, return a version where 
         * all the "yak" are removed, but the "a" can be any char. The "yak" strings 
         * will not overlap. 
        */
        public static string DoNotYak(string str)
        {
            //string pattern = "y.k";
            //string result = Regex.Replace(str, pattern, "");
            //return result;

            string newStr = "";
            int index = 0;
            do
            {
                if (index >= str.Length - 3)
                {
                    if (str[index].ToString() != "y" || str[index + 2].ToString() != "k") 
                    {
                        newStr += str.Substring(index);
                    }
                    break;
                } 
                else
                {
                    if (str[index].ToString() == "y" && str[index + 2].ToString() == "k")
                    {
                        index += 3;
                    } 
                    else
                    {
                        newStr += str[index];
                        index++;
                    }
                }
            } while (true);

            return newStr;
        }

        /* Given an array of ints, return the number of times that two 6's are next to 
         * each other in the array. Also count instances where the second "6" is 
         * actually a 7.
        */
        public static int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && (numbers[i + 1] == 6 || numbers[i + 1] == 7))
                {
                    count++;
                }
            }
            return count;
        }

        /* Given an array of ints, we'll say that a triple is a value appearing 3 times 
         * in a row in the array. Return true if the array does not contain any triples. 
        */
        public static bool NoTriples(int[] numbers)
        {
            bool noTriples = true;
            int count = 0;

            for (int i = 0; i <= numbers.Length - 3; i++) {
                if (numbers[i] == numbers[i+1] && numbers[i+1] == numbers[i+2])
                {
                    count++;
                }
            }
            if (count != 0)
            {
                noTriples = false;
            }
            return noTriples;
        }

        /* Given an array of ints, return true if it contains a 2, 7, 1 pattern --
         * a value, followed by the value plus 5, followed by the value minus 1. 
         */
        public static bool Pattern51(int[] numbers)
        {
            bool patternFound = false;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 1] == numbers[i] + 5 && numbers[i + 2] == numbers[i] - 1)
                {
                    patternFound = true;
                }
                else
                {
                    continue;
                }
            }
            return patternFound;
        }
    }
}
