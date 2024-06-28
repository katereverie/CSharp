using RockPaperScissors.Actions;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Tests.TestImplementations
{
    public class AlwaysPicksPaper : IChoiceGetter
    {
        public Choice GetChoice()
        {
            return Choice.Paper;
        }
    }
}
