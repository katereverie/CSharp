using GuessingGame.UI.Interfaces;

namespace GuessingGame.UI
{
    public class GameManager
    {
        // hold inplementations
        private INumberGenerator _numberGenerator;
        private int _numberToGuess;

        // property public for reading
        public int MaxGuess { get { return _numberGenerator.MaxGuess;} }
        // property public for reading, but setting private for class method member
        public int GuessCount { get; private set; } = 0;

        // constructor to inject dependency
        public GameManager(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;
            _numberToGuess = _numberGenerator.GenerateNumber();
        }

        public GuessResult ParseGuess(int userGuess)
        {

            if (userGuess < _numberToGuess)
            {
                return GuessResult.TooLow;
            }
            else if (userGuess > _numberToGuess)
            {
                return GuessResult.TooHigh;
            }
            else
            {  
                return GuessResult.Correct;
            }
        }

        public int CountGuesses()
        {
            return GuessCount += 1;
        }
    }
}
