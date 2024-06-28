namespace SlopeOfALine
{
    public static class ConsoleIO
    {
        public static Point GetPoint(string prompt)
        {
            Console.WriteLine(prompt);

            double x;
            double y;

            Console.Write("Enter X Coordinate: ");

            do
            {
                if (double.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }

                Console.WriteLine("Invalid value.");

            } while (true);

            Console.Write("Enter Y Coordinate: ");
            do
            {
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    break;
                }

                Console.WriteLine("Invalid value.");

            } while (true);

            Point point = new Point(x, y);
            Console.Write("\n\n");
            return point;
        }

        private static string DisplayCoordinate(Point point)
        {
            return $"({point.X}, {point.Y})";
        }

        public static void OutputSlope(Line line)
        {
            if (line.isVertical) {
                Console.WriteLine($"A line with points {DisplayCoordinate(line.startPoint)} and {DisplayCoordinate(line.endPoint)} is a vertical line and has no slope.");
                return;
            }

            Console.WriteLine($"The slope of a line with points {DisplayCoordinate(line.startPoint)} and {DisplayCoordinate(line.endPoint)} is {line.CalculateSlope()}.");
        }
    }
}
