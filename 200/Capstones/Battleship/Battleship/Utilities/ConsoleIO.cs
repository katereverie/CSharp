using Battleship.UI.Interfaces;
using System.Text.RegularExpressions;

namespace Battleship.UI.Utilities
{
    public static class ConsoleIO
    {
        private readonly static Regex _coordinateRegex = new Regex(@"^[A-J](10|[1-9])$");

        public static string GetPlayerName(string prompt)
        {
            string playerName;
            
            do
            {
                Console.Write(prompt);

                playerName = Console.ReadLine().Trim();

                if (!String.IsNullOrEmpty(playerName))
                {
                    return playerName;
                }

                Console.WriteLine("Even an obscure captain has a name. What's yours?");

            } while (true);
            

        }

        public static string GetStringCoordinate(string prompt)
        {
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine().Trim().ToUpper();

                if (_coordinateRegex.IsMatch(input))
                {
                    return input;
                }

                PrintErrorMessage($"Invalid Coordinate Format.");
                
            } while (true);

        }  

        public static char GetDirection()
        {
            do
            {
                Console.Write("Place ship (V)ertical or (H)orizontal: ");

                if (char.TryParse(Console.ReadLine().Trim().ToUpper(), out char direction))
                {
                    if (direction == 'V' ||  direction == 'H')
                    {
                        return direction;
                    }

                    PrintErrorMessage($"{direction} is not a recognzied direction in this game.");
                    continue;
                }

                PrintErrorMessage("Input illegitimate ");

            } while (true);
        }

        public static void PrintErrorMessage(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }

        public static void PrintBoard(char[] board) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n     A B C D E F G H I J");
            Console.ResetColor();

            // outer grid
            for (int i = 1; i <= 10; i++)
            {   
                Console.ForegroundColor = ConsoleColor.Green;

                switch (i)
                {
                    case 10:
                        Console.Write($"  {i} ");
                        break;
                    default:
                        Console.Write($"   {i} ");
                        break;
                }

                Console.ResetColor();

                char[] rowToPrint = new char[10];
                int startIndex = (i - 1) * 10;
                Array.Copy(board, startIndex, rowToPrint, 0, 10);
                
                // inner grid
                for (int j = 0; j < 10; j++)
                {
                    if (rowToPrint[j] == '\0')
                    {
                        Console.Write("- ");
                    }
                    else if (rowToPrint[j] == 'H')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{rowToPrint[j]} ");
                        Console.ResetColor();
                        continue;
                    }
                    else if (rowToPrint[j] == 'M') 
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{rowToPrint[j]} ");
                        Console.ResetColor();
                        continue;
                    }
                    else if (rowToPrint[j] != 'M' && rowToPrint[j] != 'H')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"{rowToPrint[j]} ");
                        Console.ResetColor();
                    }

                }

                Console.Write("\n");
            }

            Console.WriteLine();
        }

        public static void PrintPlayerSelectionRules()
        {
            Console.Write("==========================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Player Selection Rules");
            Console.ResetColor();
            Console.WriteLine("==========================");
            Console.WriteLine("| You may choose to play with the Computer or with another human player. |");
            Console.WriteLine("| You may not choose two Computer Players to play against each other.    |");
            Console.WriteLine("==========================================================================\n");
        }

        public static void PrintShipPlacementRules()
        {
            Console.Write("====================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ship Placement Rules");
            Console.ResetColor();
            Console.WriteLine("====================================");
            Console.WriteLine("| 1. You may only place a ship with on-grid coordinates: from A-J (column) and 1-10 (row). |");
            Console.WriteLine("| 2. You will be prompted for a starting coordinate and placement direction.               |");
            Console.WriteLine("| 3. You may not place a ship that has any coordinate that overlaps with other ships.      |");
            Console.WriteLine("============================================================================================\n");
        }

        public static void PrintGameRules()
        {
            Console.Write("=============================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Game Rules");
            Console.ResetColor();
            Console.WriteLine("=============================");
            Console.WriteLine("| 1. You may place only one shot per turn.                         |");
            Console.WriteLine("| 2. You may not repeat placed shots.                              |");
            Console.WriteLine("| 3. Whoever sinks all 5 ships of the other player claims victory. |");
            Console.WriteLine("====================================================================\n");
        }

        public static void PrintPlayerSummary(IPlayer nextPlayer, int remainingShips, int remainingHits)
        {
            Console.WriteLine($"\n{nextPlayer.Name}: | Remaining Ships: {remainingShips} | Remaining Hits: {remainingHits} |\n");
        }
    }
}