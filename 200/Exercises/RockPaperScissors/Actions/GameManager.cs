using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Actions
{
    public class GameManager
    {
        public int Wins { get; private set; } = 0;
        public int Losses { get; private set; } = 0;
        public int Ties { get; private set; } = 0;

        // hold implementations, called coding to interfaces, not to implementations
        private IChoiceGetter _p1ChoiceGetter; // player 1 
        private IChoiceGetter _p2ChoiceGetter; // player 2

        public Choice Player1Choice {  get; private set; }
        public Choice Player2Choice { get; private set; }

        // constructor
        public GameManager(IChoiceGetter p1, IChoiceGetter p2)
        {
            _p1ChoiceGetter = p1;
            _p2ChoiceGetter = p2;
        }

        public RoundResult PlayRound()
        {
            Player1Choice = _p1ChoiceGetter.GetChoice();
            Player2Choice = _p2ChoiceGetter.GetChoice();

            if (Player1Choice == Player2Choice)
            {
                Ties++;
                return RoundResult.Tie;
            }
            else if ((Player1Choice == Choice.Rock && Player2Choice == Choice.Scissors) ||
                     (Player1Choice == Choice.Scissors && Player2Choice == Choice.Paper) ||
                     (Player1Choice == Choice.Paper && Player2Choice == Choice.Rock))
            {
                Wins++;
                return RoundResult.PlayerWins;
            }
            else
            {
                Losses++;
                return RoundResult.ComputerWins;
            }
        }

    }
}
