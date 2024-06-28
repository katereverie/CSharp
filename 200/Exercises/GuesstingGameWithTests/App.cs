using GuessingGame.UI.Implementations;
using Microsoft.VisualBasic;

namespace GuessingGame.UI
{
    public static class App
    {
        public static void Run()
        {
            GameManager gameManager;
            
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Guessing Game!");

                gameManager = new GameManager(NumberGeneratorFactory.GetNumberGenerator());

                Console.WriteLine($"I'm thinking of a number between 1 and {gameManager.MaxGuess}. Can you guess it?");

                GuessResult guessResult;

                do
                {
                    int userGuess = ConsoleIO.GetGuess(gameManager.MaxGuess);
                    gameManager.CountGuesses();
                    guessResult = gameManager.ParseGuess(userGuess);
                    ConsoleIO.DisplayGuessResult(guessResult);

                } while (guessResult != GuessResult.Correct);
                

                Console.WriteLine($"It took you {gameManager.GuessCount} guesses.");

            } while (ConsoleIO.PlayAgain());
        }
    }
}
