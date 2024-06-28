namespace GuessingGame.Actions
{
    public class GameManager
    {
        private int _randomNumber;

        public int GetRandomNumber(int maxValue)
        {
            Random randomObj = new Random();
            _randomNumber = randomObj.Next(1, maxValue + 1);
            Console.WriteLine($"\n\nI am thinking of a number between 1 and {maxValue}. Can you guess it?");
            return _randomNumber;
        }
    }
}
