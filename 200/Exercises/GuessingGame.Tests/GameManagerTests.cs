using GuessingGame.Tests.TestImplementations;
using GuessingGame.UI;
using NUnit.Framework;

namespace GuessingGame.Tests
{
    public class GameManagerTests
    {
        GameManager gameManager = new GameManager(new AlwaysGenerateFive());

        [Test]
        public void TestParseGuess_TooHigh()
        {

            var guessResult = gameManager.ParseGuess(4);

            Assert.AreEqual(GuessResult.TooLow, guessResult);
        }

        [Test]
        public void TestParseGuess_TooLow()
        {
            var guessResult = gameManager.ParseGuess(6);
            
            Assert.AreEqual(GuessResult.TooHigh, guessResult);
        }

        [Test]
        public void TestGetGuess_Correct() 
        {
            var guessResult = gameManager.ParseGuess(5);

            Assert.AreEqual(GuessResult.Correct, guessResult);
        }

        [Test]
        public void TestGuessCount()
        {
            gameManager.ParseGuess(4);
            gameManager.CountGuesses();
            gameManager.ParseGuess(6);
            gameManager.CountGuesses();
            gameManager.ParseGuess(5);
            gameManager.CountGuesses();

            Assert.AreEqual(3, gameManager.GuessCount);
        }

    }
}
