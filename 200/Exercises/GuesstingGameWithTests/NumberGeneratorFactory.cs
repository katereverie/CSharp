using GuessingGame.UI.Implementations;
using GuessingGame.UI.Interfaces;

namespace GuessingGame.UI
{
    public static class NumberGeneratorFactory
    {
        public static INumberGenerator GetNumberGenerator()
        {
            if (ConsoleIO.ChooseDefaultOrEnterMaxNumber())
            {
                return new UserPromptGenerator();
            }
            else
            {
                return new DefaultNumberGenerator();
            }
        }
    }
}
