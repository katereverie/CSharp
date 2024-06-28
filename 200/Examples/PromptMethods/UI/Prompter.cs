using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptMethods.UI
{
    // XML Documentation Comment
    /// <summary>
    /// Contains methods for propmpting users.
    /// </summary>
    public static class Prompter
    {
        /// <summary>
        /// Propmpts the user for a non-zero length string
        /// </summary>
        /// <param name="prompt">The text you want to display to the user as a prompt</param>
        /// <returns>A non-zero length string</returns>
        public static string GetRequiredString(string prompt)
        {
            string input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("You must enter at least one character!");
                }
            } while (true);
        }
    }
}
