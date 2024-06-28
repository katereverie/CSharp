using ClassFields;
// namespaces are a way to ensure a unique type name

Coordinate c1 = new Coordinate();

c1.X = 3;
c1.Y = 5.5;

// compare this to line 20.
System.Console.WriteLine($"This coordinate has a point of ({c1.X}, {c1.Y}).");

// the default value of a class type is always null (when declaring an array of the said class type)
Coordinate[] myPoints = new Coordinate[5];

//drilling down from object to object ...
myPoints[0] = new Coordinate();
myPoints[0].X = 2;
myPoints[0].Y = -1.5;

ClassFields.Custom.Console myConsole = new ClassFields.Custom.Console();