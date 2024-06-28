using GuessingGame.UI.Interfaces;

namespace GuessingGame.UI.Implementations
{
    public class DefaultNumberGenerator : INumberGenerator
    {
        private static Random _random = new Random();

        public int MaxGuess { get; } = 20;

        public int GenerateNumber()
        {
            return _random.Next(1, MaxGuess + 1);
        }
    }
}
