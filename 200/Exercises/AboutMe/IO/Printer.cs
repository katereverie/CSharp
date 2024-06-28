using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMe.IO
{
    public static class Printer
    {
        public static void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("About You");
            Console.WriteLine("================================");
        }

        public static void PrintAboutMe(string firstName, string lastName, DateTime dateOfBirth, int age, string maritalStatus)
        {
            Console.WriteLine($"Name: {lastName}, {firstName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Date of Birth: {dateOfBirth:MM/dd/yyyy}");
            Console.WriteLine($"Marital Status: {(maritalStatus == "S"? "Single":"Married")}");
        }
    }
}
