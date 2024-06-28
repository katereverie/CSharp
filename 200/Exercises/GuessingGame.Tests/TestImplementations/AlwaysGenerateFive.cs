using GuessingGame.UI.Interfaces;

namespace GuessingGame.Tests.TestImplementations
{
    public class AlwaysGenerateFive : INumberGenerator
    {
        public int MaxGuess { get; set; } = 20;

        public int GenerateNumber()
        {
            return 5;
        }
    }
}
