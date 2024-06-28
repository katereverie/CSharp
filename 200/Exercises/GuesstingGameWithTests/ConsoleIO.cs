namespace GuessingGame.UI
{
    public static class ConsoleIO
    {

        public static bool ChooseDefaultOrEnterMaxNumber()
        {
            do
            {
                Console.Write("Would you like to\n1.accept the default (1 to 20)\n2.enter your own maximum number?\nChoose 1 or 2: ");
                if (int.TryParse(Console.ReadLine(), out int response))
                {
                    if (response == 1)
                    {
                        return false;
                    }
                    else if (response == 2)
                    {
                        return true;
                    }

                    Console.WriteLine("Please enter either 1 or 2.");
                }

                Console.WriteLine("Please enter a number that is either 1 or 2.");

            } while (true);
            
        }

        public static int GetMaxNumber()
        {
            
            while (true)
            {
                Console.Write("Enter the maximum value for the number you are seeking: ");
                if (int.TryParse(Console.ReadLine(), out int maxNumber) && maxNumber > 1)
                {
                    return maxNumber;
                }
                Console.WriteLine("Invalid input. Please enter a positive integer greater than 1.");
            }
        }

        public static int GetGuess(int maxGuess)
        {
            while (true)
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out int guess) && guess >= 1 && guess <= maxGuess)
                {
                    return guess;
                }
                Console.WriteLine($"Invalid input. Please enter an integer between 1 and {maxGuess}.");
            }
        }

        public static bool PlayAgain()
        {
            while (true)
            {
                Console.Write("Would you like to play again? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    return true;
                }
                else if (response == "no")
                {
                    return false;
                }
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }

        public static void DisplayGuessResult(GuessResult guessResult)
        {
            switch (guessResult)
            {
                case GuessResult.TooLow:
                    Console.WriteLine("Higher");
                    break;
                case GuessResult.TooHigh:
                    Console.WriteLine("Lower");
                    break;
                case GuessResult.Correct:
                    Console.WriteLine("You got it");
                    break;
            }
        }
    }
}
