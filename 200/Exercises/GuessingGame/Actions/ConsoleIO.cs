namespace GuessingGame.Actions
{
    public static class ConsoleIO
    {
        public static int GetMaxValue()
        {
            do
            {
                Console.Write("Enter the maximum value for the number you are seeking: ");

                if (int.TryParse(Console.ReadLine(), out int maxValue))
                {
                    if (maxValue > 1)
                    {
                        return maxValue;
                    }

                    Console.WriteLine("The maximum value must be greather than 1.");
                }

                Console.WriteLine("The value must an integer.");

            } while (true);
            
        }

        public static int GetGuessValue(int maxValue)
        {
            do
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(),out int guessValue))
                {
                    if (guessValue >= 1 && guessValue <= maxValue)
                    {
                        return guessValue;
                    }
                    Console.WriteLine("Your guess must be greather than 0 and less than or equal to the maximum value you set.");
                }

                Console.WriteLine("Your guess must be numeric.");

            } while (true);
        }

        public static string GetAnswer()
        {
            do
            {
                Console.Write("Play again? Choose 'yes' or 'no': ");
                string answer = Console.ReadLine().ToLower().Trim();

                if (answer == "yes" || answer == "no")
                {
                    return answer;
                }

                Console.WriteLine("Your answer must be either 'yes' or 'no'");

            } while (true);
        }
    }
}
