using GuessingGame.UI.Interfaces;

namespace GuessingGame.UI.Implementations
{
    public class UserPromptGenerator : INumberGenerator
    {
        private static Random _random = new Random();
        public int MaxGuess {  get; private set; }

        public int GenerateNumber()
        {
            MaxGuess = ConsoleIO.GetMaxNumber();
            return _random.Next(1, MaxGuess + 1);
        }
    }
}
