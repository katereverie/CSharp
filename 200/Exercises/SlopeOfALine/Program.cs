using SlopeOfALine;

Point startPoint = ConsoleIO.GetPoint("Start Point");
Point endPoint = ConsoleIO.GetPoint("End Point");

Line line = new Line(startPoint, endPoint);

ConsoleIO.OutputSlope(line);