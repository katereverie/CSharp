


namespace RockPaperScissors.Actions
{
    public static class ConsoleIO
    {
        public static Choice GetChoice()
        {

            while (true)
            {
                Console.Write("\nPlease enter your choice: (R)ock, (P)aper, (S)cissors: ");
                char userInput = char.ToUpper(Console.ReadKey().KeyChar);

                switch (userInput)
                {
                    case 'R':
                        return Choice.Rock;
                    case 'P':
                        return Choice.Paper;
                    case 'S':
                        return Choice.Scissors;
                    default:
                        Console.WriteLine("\nInvalid choice.");
                        break;
                }

            }
        }

        public static bool PlayAgain()
        {
            do
            {
                Console.Write("Play again? (Y/N): ");
                char keyChar = char.ToUpper(Console.ReadKey().KeyChar);
                
                if (keyChar != 'Y' && keyChar != 'N')
                {
                    Console.WriteLine("\nPlease press either 'Y' or 'N'.");
                    continue;
                }

                return keyChar == 'Y' ? true : false;

            } while (true);
        }

        public static void DisplayChoices(Choice player1Choice, Choice player2Choice)
        {
            Console.WriteLine($"Player 1 picked {player1Choice} and player 2 picked {player2Choice}");
        }

        public static void DisplayResult(RoundResult result)
        {
            switch (result)
            {
                case RoundResult.Tie:
                    Console.WriteLine("It's a tie!");
                    break;
                case RoundResult.PlayerWins:
                    Console.WriteLine("You win!");
                    break;
                case RoundResult.ComputerWins:
                    Console.WriteLine("You lost!");
                    break;
            }
        }


        public static void DisplaySumary(int wins, int losses, int ties)
        {
          
            Console.WriteLine($"\n\nGame Summary:\n=============\nWins: {wins}\nLosses: {losses}\nTies: {ties}");
            Console.WriteLine("Thank you for playing.");
            
        }
    }
}
