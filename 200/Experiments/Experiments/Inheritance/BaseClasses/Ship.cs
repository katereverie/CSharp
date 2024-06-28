namespace Inheritance.BaseClasses
{
    public class Ship
    {
        public string Name {  get; private set; }
        public char Symbol { get; private set; }
        public int Size { get; private set; }
        public Coordinate[] Coordinates { get; set; }

        public Ship(string name, int size)
        {
            Name = name;
            Symbol = name[0];
            Size = size;
            Coordinates = new Coordinate[size];
        }

        public void SetCoordinates(Coordinate startingCoordinate, string direction)
        {

            if (direction != "V" && direction != "H") 
            {
                throw new ArgumentException("Placement direction must be either (V)ertical or (H)orizontal.");
            }

            if (direction == "V")
            {
                for (int i = 0; i < Coordinates.Length; i++)
                {
                    Coordinates[i] = new Coordinate(startingCoordinate.X, startingCoordinate.Y + i);
                }
            }

            if (direction == "H")
            {
                for (int i = 0; i < Coordinates.Length; i++)
                {
                    Coordinates[i] = new Coordinate(startingCoordinate.X + i, startingCoordinate.Y);
                }
            }
        }
    }
}
