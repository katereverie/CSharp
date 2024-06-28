using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMinis.BLL
{
    public class ArrayExercises
    {
        /* Given an array of ints, return true if 6 appears as either the 
         * first or last element in the array. The array will be length 1 
         * or more. 
        */
        public static bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
            {
                return true;
            }
            return false;
        }

        /* Given an array of ints, return true if the array is length 1 or more, 
         * and the first element and the last element are equal. 
        */
        public static bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length >= 1 && numbers[0] == numbers[numbers.Length - 1])
            {
                return true;
            }
            return false;
        }

        /* Given 2 arrays of ints, a and b, return true if they have the same first 
         * element or they have the same last element. Both arrays will be length 1 or more. 
        */
        public static bool CommonEnd(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                return true;
            }
            return false;
        }

        /* Given an array of ints, return the sum of all the elements. */
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        /* Given an array of ints, return an array with the elements "rotated left" 
         * so {1, 2, 3} yields {2, 3, 1}. 
        */
        public static int[] RotateLeft(int[] numbers)
        {
            int size = numbers.Length;
            int[] result = new int[size];
            
   
            for (int i = 0; i < size - 1; i++)
            {
                result[i] = numbers[i + 1];
            }
            result[size - 1] = numbers[0];
            return result;
        }

        /* Given an array of ints length 3, return a new array with the elements in 
         * reverse order, so for example {1, 2, 3} becomes {3, 2, 1}. 
        */
        public static int[] Reverse(int[] numbers)
        {
            //int size = numbers.Length;
            //int[] reversedNumbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    reversedNumbers[i] = numbers[size - 1 - i];
            //}
            //return reversedNumbers;
            Array.Reverse(numbers);
            return numbers;
        }

        /* Given an array of ints, figure out which is larger between the first and 
         * last elements in the array, and set all the other elements to be that value. 
         * Return the changed array. 
        */
        public static int[] HigherWins(int[] numbers)
        {
            int bigger = numbers[0] > numbers[numbers.Length - 1] ? numbers[0] : numbers[numbers.Length - 1];

            int[] newArr = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                newArr[i] = bigger;
            }
            return newArr;
        }

        /* Given 2 int arrays, a and b, each length 3, return a new array length 2 
         * containing their middle elements. 
        */
        public static int[] GetMiddle(int[] a, int[] b)
        {
            int[] midArr = new int[2];
            midArr[0] = a[1];
            midArr[1] = b[1];
            return midArr;
        }

        /* Given an int array, return true if it contains an even number (HINT: Use Mod (%)). */
        public static bool HasEven(int[] numbers)
        {
            bool containsEvenNum = false;
            int index = 0;

            do
            {
                if (numbers[index] % 2 == 0)
                {
                    containsEvenNum = true;
                    break;
                }
                index++;

            } while (index < numbers.Length);
            return containsEvenNum;
        }

        /* Given an int array, return a new array with double the length where its last element is 
         * the same as the original array, and all the other elements are 0. The original array 
         * will be length 1 or more. Note: by default, a new int array contains all 0's. 
        */
        public static int[] KeepLast(int[] numbers)
        {
            int length = numbers.Length;
            int[] newArr = new int[length * 2];

            Array.Fill(newArr, 0);
            newArr[length * 2 - 1] = numbers[length - 1];

            return newArr;
        }

        /* Given an int array, return true if the array contains 2 twice, or 3 twice. */
        public static bool Double23(int[] numbers)
        {
            bool found = false;
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    count2++;
                }
                if (numbers[i] == 3)
                {
                    count3++;
                }
            }

            if (count2 == 2 || count3 == 2)
            {
                found = true;
            }
            return found;
        }

        /* Given an int array length 3, if there is a 2 in the array immediately followed 
         * by a 3, set the 3 element to 0. Return the changed array. 
        */
        public static int[] Fix23(int[] numbers)
        {
            int index = 0;
            do
            {
                if (numbers[index] == 2 && numbers[index + 1] == 3)
                {
                    numbers[index + 1] = 0;
                }
                index++;

            } while (index < numbers.Length - 1);

            return numbers;
        }

        /* We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1.
         * Return true if the given array contains an unlucky 1 in the first 2 or last 2 
         * positions in the array. 
        */
        public static bool Unlucky1(int[] numbers)
        {
            if ((numbers[0] == 1 && numbers[1] == 3) || 
                (numbers[1] == 1 && numbers[2] == 3) || 
                (numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3))
            {
                return true;
            }
            return false;
        }

        /* Given 2 int arrays, a and b, return a new array length 2 containing, as much as 
         * will fit, the elements from a followed by the elements from b. The arrays may be 
         * any length, including 0, but there will be 2 or more elements available between 
         * the 2 arrays. 
        */
        public static int[] Make2(int[] a, int[] b)
        {
            int[] newArr = new int[a.Length + b.Length];
            int[] newArr2 = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                newArr[i] = a[i];
            }
            
            for (int i = 0; i < b.Length; i++)
            {
                newArr[a.Length + i] = b[i];
            }

            newArr2[0] = newArr[0];
            newArr2[1] = newArr[1];

            return newArr2;
        }
    }
}
