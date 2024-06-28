using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class App
    {
        private ConsoleIO _io;

        public void Run() {
            // instantiate an ConsoleIO object and store it in _io.
            _io = new ConsoleIO();

            do
            {
                int choice = _io.GetMenuChoice();

                // *** use switch statement for a range of options (next time)
                if (choice == 4)
                {
                    break;
                } 
                else if (choice == 1)
                {
                    CalculateRectangle();
                } 
                else if (choice == 2 )
                {
                    CalculateCircle();
                }
                else if (choice == 3)
                {
                    CalculateTriangle();
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            } while (true);
        }

        private void CalculateRectangle() {
            Rectangle rectangle = new Rectangle();
            double length = _io.GetPositiveValue("\nEnter length: ");
            double width = _io.GetPositiveValue("Enter width: ");
            double area = rectangle.GetArea(width, length);
            Console.WriteLine($"\nThe area of a rectangle with a length of {length} and a width of {width} is {area}.");
        }

        private void CalculateCircle () { 
            Circle circle = new Circle();
            double radius = _io.GetPositiveValue("\nEnter radius: ");
            double area = circle.GetArea(radius);
            Console.WriteLine($"\nThe area of a circle with a radius of {radius} is {area:F2}.");
        }

        private void CalculateTriangle () {
            Triangle triangle = new Triangle();
            double @base = _io.GetPositiveValue("\nEnter base: ");
            double height = _io.GetPositiveValue("Enter height: ");
            double area = triangle.GetArea(@base, height);
            Console.WriteLine($"\nThe area of a triangle with a base of {@base} and a height of {height} is {area}.");
        }
    }
}
