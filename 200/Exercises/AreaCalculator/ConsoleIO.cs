using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class ConsoleIO
    {
        // display menu
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Area Calculator");
            Console.WriteLine("=================");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circile");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Quit");
        }

        // prompt users for input until input is valid, return valid input
        public int GetMenuChoice()
        {
            int choice;

            DisplayMenu();

            // validate user input 
            do
            {
                Console.Write("\nEnter Choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice < 1 || choice > 4)
                    {
                        Console.WriteLine($"{choice} is not an available choice. Please enter a number between 1 - 4");
                        continue;
                    } 
                    else
                    {
                        // break loop if choice is valid
                        return choice;
                    }
                    
                }

                Console.WriteLine("Please enter a NUMBER between 1 to 4.");

            } while (true);

        }

        // get date from for all shapes
        public double GetPositiveValue(string prompt)
        {
            double val;

            do
            {
                // prompt users for shape values
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out val))
                {
                    if (val > 0)
                    {
                        return val;
                    } 
                    else
                    {
                        Console.WriteLine("The value must be positive.");
                        continue;
                    }
                }

                Console.WriteLine("The value must be numeric.");

            } while (true);

        }

    }
}
