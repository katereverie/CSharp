using GuessingGame.Actions;

namespace GuessingGame.Workflow
{
    public static class App
    {
        public static void Run()
        {
            GameManager game = new GameManager();

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Guessing Game");

                int maxValue = ConsoleIO.GetMaxValue();
                int randomNumber = game.GetRandomNumber(maxValue);
                int count = 0;

                do
                {
                    int guess = ConsoleIO.GetGuessValue(maxValue);
                    count++;

                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Go lower!\n");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Go higher!\n");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {count} guesses.\n\n");
                        break;
                    }

                } while (true);

                if (ConsoleIO.GetAnswer() == "no")
                {
                    return;
                }


            } while (true);
            
        }
    }
}
