
using RockPaperScissors.Actions;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Tests.TestImplementations
{
    public class AlwaysPicksRock : IChoiceGetter
    {
        public Choice GetChoice()
        {
            return Choice.Rock;
        }
    }
}
