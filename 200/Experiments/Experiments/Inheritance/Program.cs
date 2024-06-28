using Inheritance;
using Inheritance.BaseClasses;

Ship s1 = new Ship("Battleship", 4);
Ship s2 = new Ship("Aircraft Carrier", 5);
Ship s3 = new Ship("Cruiser", 3);
Ship s4 = new Ship("Submarine", 2);
Ship s5 = new Ship("Destroyer", 2);

//myShip.Name = "lovely"; error because once constructed, the name, symbol, size of the ship cannot be altered.

Coordinate c1 = new Coordinate(1, 1);
Coordinate c2 = new Coordinate(2, 1);

s1.SetCoordinates(c1, "V");
Console.Write($"{s1.Name}'s coordinates are: ");

for (int i = 0; i < s1.Size; i++)
{
    Console.Write($"{s1.Coordinates[i]} ");
}

s2.SetCoordinates(c2, "H");
Console.Write($"\n{s2.Name}'s coordinates are: ");
for (int i = 0; i < s2.Size; i++)
{
    Console.Write($"{s2.Coordinates[i]} ");
}