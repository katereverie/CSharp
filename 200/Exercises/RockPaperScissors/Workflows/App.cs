using RockPaperScissors.Actions;
using RockPaperScissors.Implementations;

namespace RockPaperScissors.Workflows
{
    public static class App
    {
        public static void Run ()
        {
            GameManager gm = new GameManager (new ConsoleGetter(), new RandomGetter());

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("=================================\n\n");

            do
            
            {
                var result = gm.PlayRound();
                ConsoleIO.DisplayChoices(gm.Player1Choice, gm.Player2Choice);
                ConsoleIO.DisplayResult(result);

            } while (ConsoleIO.PlayAgain());

            ConsoleIO.DisplaySumary(gm.Wins, gm.Losses, gm.Losses);
        }
    }
}
