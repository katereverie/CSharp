using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.IO
{
    public static class Prompter
    {
        // prompt users for string input, validate and return input
        public static string GetRequiredString (string prompt)
        {
            string input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }

                Console.WriteLine("Input must have at least one character.");

            } while (true);

        }

        // prompt users for date input, validate and return date
        public static DateTime GetPastDate(string prompt)
        {
            DateTime birthDate;

            do
            {
                Console.Write(prompt);

                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    if (birthDate < DateTime.Now)
                    {
                        return birthDate;
                    }

                    Console.WriteLine("Date input must be prior to the current date.");
                    
                }
                
                Console.WriteLine("Please enter a valid date.");
                

            } while (true);
            
        }

        // prompt users for age input: int, validate and return age input
        public static int GetAgeInRange(string prompt, int minAge, int maxAge)
        {

            int age;

            do
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age >= minAge && age <= maxAge)
                    {
                        return age;
                    }

                    Console.WriteLine($"Please enter an age between {minAge}-{maxAge}.");
                }
                
                Console.WriteLine("Value must be numeric.");
                
            } while (true);
        }

        // prompt users for marital status input: string, validate and return marital status input
        public static string GetMaritalStatus()
        {
            string maritalStatus;

            do
            {
                Console.Write("Marital Status (S)ingle, (M)arried: ");
                maritalStatus = Console.ReadLine().ToUpper();

                if (maritalStatus == "S" || maritalStatus == "M")
                {
                    return maritalStatus;
                }
                
                Console.WriteLine($"Please enter either 'S' or 'M'");

            } while (true);
        }

    }
}
