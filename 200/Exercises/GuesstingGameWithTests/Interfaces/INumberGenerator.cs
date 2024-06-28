namespace GuessingGame.UI.Interfaces
{
    public interface INumberGenerator
    {
        int MaxGuess { get; }

        int GenerateNumber();
    }
}
